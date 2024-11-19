using App.Data.Entities.service;
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
					Description = "Phòng và dịch vụ tuyệt vời!" +
					"Chăn gối có mùi thơm nhẹ tui rất thích.",
					CreatedBy = 3,
					CreatedDate = now
				},
				new AppComment
				{
					Id = 2,
					Description = "Nhân viên lịch sự giao tiếp tốt, rất nhiệt tình đón tiếp chúng tôi, phòng ổn, phòng có vẻ như mới sơn lại nên nhìn sạch sẽ.",
					CreatedBy = 3,
					CreatedDate = now
				}
			// Add more seed data as needed
			);
		}
	}
}