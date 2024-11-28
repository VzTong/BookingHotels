using App.Data.Repositories;
using App.Web.Common;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace App.Web.Controllers
{
	public class AppControllerBase : Controller
	{
		protected readonly IMapper _mapper;
		protected readonly GenericRepository _repository;
		protected const int DEFAULT_PAGE_SIZE = 20;
		protected const string EXCEPTION_ERR_MESG = "Đã xảy ra lỗi trong quá trình xử lý dữ liệu (500)";
		protected const string MODEL_STATE_INVALID_MESG = "Dữ liệu không hợp lệ, vui lòng kiểm tra lại";
		protected const string PAGE_NOT_FOUND_MESG = "Không tìm thấy trang";
		protected readonly string DefaultImagePath = "upload/img_avt/astronaut.png";// Đường dẫn đến ảnh mặc định

		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
		protected string CurrentUsername { get => HttpContext.User.Identity.Name; }
		public AppControllerBase(IMapper mapper, GenericRepository repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		/// <summary>
		/// Gán thông báo lỗi để hiển thị lên view
		/// </summary>
		/// <param name="mesg">Thông báo lỗi</param>
		/// <param name="modelStateIsInvalid">Đặt là true khi lỗi validate dữ liệu</param>
		protected void SetErrorMesg(string mesg, bool modelStateIsInvalid = false)
		{
			TempData["Err"] = mesg;
			if (modelStateIsInvalid)
			{
				// hiển thị tin nhắn lỗi ở file log
				var invalidMesg = string.Join("\n", ModelState.Values
												.SelectMany(v => v.Errors)
												.Select(e => e.ErrorMessage));
			}
		}

		protected void SetSuccessMesg(string mesg) => TempData["Success"] = mesg;

		protected byte[] HashHMACSHA512WithKey(string pwd, byte[] key)
		{
			HMACSHA512 hmac = new(key);
			var pwdByte = Encoding.UTF8.GetBytes(pwd);
			return hmac.ComputeHash(pwdByte);
		}

		protected HashResult HashHMACSHA512(string pwd)
		{
			var hashResult = new HashResult();
			HMACSHA512 hmac = new();
			var pwdByte = Encoding.UTF8.GetBytes(pwd);
			hashResult.Value = hmac.ComputeHash(pwdByte);
			hashResult.Key = hmac.Key;
			return hashResult;
		}

		/// <summary>
		/// Upload và trả về tên file, file đó được lưu trong thư mục Upload
		/// </summary>
		/// <param name="file">Là file đó</param>
		/// <param name="dir">Thư mục lưu file</param>
		/// <returns></returns>
		protected string UploadFile(IFormFile file, string dir)
		{
			if (file == null)
			{
				// Người dùng không upload ảnh, sử dụng ảnh mặc định
				var defaultImageBytes = System.IO.File.ReadAllBytes(DefaultImagePath.TrimStart('/'));
				return Convert.ToBase64String(defaultImageBytes);
			}

			// upload ảnh bìa (CoverImg)
			var fName = file.FileName;
			fName = Path.GetFileNameWithoutExtension(fName)
					+ DateTime.Now.Ticks
					+ Path.GetExtension(fName);

			// Gán giá trị cột CoverImg
			var res = "upload/img/" + fName;

			// Tạo đường dẫn tuyệt đối (Ví dụ: E:/Project/wwwroot/upload/xxxx.jpg)
			fName = Path.Combine(dir, "upload/img", fName);

			// Tạo Stream để lưu file
			var stream = System.IO.File.Create(fName);
			file.CopyTo(stream);
			stream.Dispose(); // Giải phóng bộ nhớ

			return res;
		}
	}
}