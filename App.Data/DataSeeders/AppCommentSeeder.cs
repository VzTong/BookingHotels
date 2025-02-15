﻿using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppCommentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppComment> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppComment
				{
					Id = 1,
					Description = "Phòng và dịch vụ tuyệt vời! Chăn gối có mùi thơm nhẹ tui rất thích.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 3,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 2,
					Description = "Nhân viên lịch sự giao tiếp tốt, rất nhiệt tình đón tiếp chúng tôi, phòng ổn, phòng có vẻ như mới sơn lại nên nhìn sạch sẽ.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 9,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 3,
					Description = "Khách sạn có vị trí thuận tiện, gần trung tâm thành phố. Phòng ốc sạch sẽ, tiện nghi.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 7,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 4,
					Description = "Dịch vụ đặt phòng nhanh chóng, nhân viên hỗ trợ nhiệt tình. Sẽ quay lại lần sau.",
					Rating = DB.CommentRating.GOOD_ID,
					CreatedBy = 10,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 5,
					Description = "Phòng rộng rãi, thoáng mát. Bữa sáng ngon miệng và đa dạng.",
					Rating = DB.CommentRating.GOOD_ID,
					CreatedBy = 17,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 6,
					Description = "Giá cả hợp lý, dịch vụ tốt. Nhân viên thân thiện và chuyên nghiệp.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 8,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 7,
					Description = "Khách sạn có hồ bơi và phòng gym, rất tiện lợi cho khách lưu trú dài ngày.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 14,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 8,
					Description = "Dịch vụ đặt phòng trực tuyến dễ dàng, nhanh chóng. Nhân viên hỗ trợ tận tình.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 13,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 9,
					Description = "Phòng có view đẹp, nhìn ra biển. Rất thích hợp cho kỳ nghỉ dưỡng.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 12,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 10,
					Description = "Khách sạn có nhiều tiện ích, từ nhà hàng, quán bar đến spa. Rất hài lòng với dịch vụ.",
					Rating = DB.CommentRating.GREAT_ID,
					CreatedBy = 11,
					CreatedDate = now
				}
			);

		}
	}
}