﻿using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
	public class AppCommentConfig : IEntityTypeConfiguration<AppComment>
	{
		public void Configure(EntityTypeBuilder<AppComment> builder)
		{
			builder.ToTable(DB.AppComment.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Description)
				.IsRequired()
				.HasMaxLength(DB.AppComment.DESC_LENGTH);

			builder.Property(x => x.Rating)
				.IsRequired();

			// FK - AppUser
			builder.HasOne(x => x.User)
				.WithMany(x => x.Comments)
				.HasForeignKey(x => x.CreatedBy)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}