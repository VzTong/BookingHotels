using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
	public class AppCommentDetailConfig : IEntityTypeConfiguration<AppCommentDetail>
	{
		public void Configure(EntityTypeBuilder<AppCommentDetail> builder)
		{
			builder.ToTable(DB.AppCommentDetail.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.CmtDesc)
				.IsRequired()
				.HasMaxLength(DB.AppCommentDetail.CMT_DESC_LENGTH);

			builder.Property(x => x.UserName)
				.IsRequired()
				.HasMaxLength(DB.AppCommentDetail.USER_NAME_LENGTH);

			builder.Property(x => x.RoomName)
				.IsRequired()
				.HasMaxLength(DB.AppCommentDetail.ROOM_NAME_LENGTH);

			builder.Property(x => x.RoomNumber)
				.IsRequired()
				.HasMaxLength(DB.AppCommentDetail.ROOM_NUMBER_LENGTH);

			// FK - AppComment
			builder.HasOne(x => x.Comment)
				.WithMany(x => x.CommentDetails)
				.HasForeignKey(x => x.CommentId)
				.OnDelete(DeleteBehavior.Restrict);

			// FK - AppUser
			builder.HasOne(x => x.User)
				.WithMany(x => x.CommentDetails)
				.HasForeignKey(x => x.CreatedBy)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}