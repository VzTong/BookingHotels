﻿using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.Common.Helpers;
using App.Web.WebConfig.Consts;
using AutoMapper;
using elFinder.NetCore;
using elFinder.NetCore.Drivers.FileSystem;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Admin.Controllers
{
	public class FileManagerController : AppControllerBase
	{
		public FileManagerController(IMapper mapper, GenericRepository repository) : base(mapper, repository)
		{
		}

		[Route("file-manager")]
		[AppAuthorize()]
		public IActionResult Index()
		{
			return View();
		}

		[Route("file-manager/connector")]
		[AppAuthorize()]
		public async Task<IActionResult> Connector()
		{
			var connector = GetConnector();
			return await connector.ProcessAsync(Request);
		}

		[Route("file-manager/thumb/{hash}")]
		public async Task<IActionResult> Thumbs(string hash)
		{
			var connector = GetConnector();
			return await connector.GetThumbnailAsync(HttpContext.Request, HttpContext.Response, hash);
		}

		private Connector GetConnector()
		{
			var isFileSystemManager = User.IsInPermission(AuthConst.FileManager.MANAGE_ALL_USER_FILES);
			var driver = new FileSystemDriver();

			string absoluteUrl = UriHelper.BuildAbsolute(Request.Scheme, Request.Host);
			var uri = new Uri(absoluteUrl);
			var userPath = $"{AppConst.SYSTEM_FILE_PATH}/{CurrentUsername}";
			var userFullPath = PathHelper.MapPath(userPath);
			var thumbPath = $"{uri.Scheme}://{uri.Authority}/file-manager/thumb/";
			var userRootDir = new RootVolume(userFullPath, $"{uri.Scheme}://{uri.Authority}/{userPath}/", thumbPath)
			{
				//IsReadOnly = !User.IsInRole("Administrators")
				IsReadOnly = false, // Can be readonly according to user's membership permission
				IsLocked = false, // If locked, files and directories cannot be deleted, renamed or moved
				Alias = "File của tôi", // Tên hiển thị ở giao diện
				MaxUploadSizeInKb = isFileSystemManager ? AppConst.MANAGER_MAX_SIZE_UPLOAD_IN_KB : AppConst.USER_MAX_SIZE_UPLOAD_IN_KB,
				// Upload file type constraints
				UploadDeny = AppConst.DENY_FILES,
			};
			driver.AddRoot(userRootDir);

			// Dành cho account có quyền tòan hệ thống
			if (isFileSystemManager)
			{
				var rootPath = PathHelper.MapPath(AppConst.SYSTEM_FILE_PATH);
				var rootDir = new RootVolume(rootPath, $"{uri.Scheme}://{uri.Authority}/{AppConst.SYSTEM_FILE_PATH}/", thumbPath)
				{
					IsReadOnly = false, // Can be readonly according to user's membership permission
					IsLocked = false, // If locked, files and directories cannot be deleted, renamed or moved
					Alias = "File hệ thống", // Tên hiển thị ở giao diện
					MaxUploadSizeInKb = AppConst.MANAGER_MAX_SIZE_UPLOAD_IN_KB,
				};
				driver.AddRoot(rootDir);
			}

			return new Connector(driver)
			{
				// This allows support for the "onlyMimes" option on the client.
				MimeDetect = MimeDetectOption.Internal
			};
		}
	}
}