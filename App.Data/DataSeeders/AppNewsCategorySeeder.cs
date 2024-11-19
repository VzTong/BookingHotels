using App.Data.Entities.News;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppNewsCategorySeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppNewsCategory> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo loại tin tức
			builder.HasData(
				new AppNewsCategory
				{
					Id = 1,
					Title = "Tour du lịch",
					Slug = "tour-du-lich",
					Content = "Cung cấp thông tin về các tour du lịch",
					CoverImgPath = "files/ImgNewsCate/Tour.jpg",
					CreatedDate = now
				},

				new AppNewsCategory
				{
					Id = 2,
					Title = "Địa điểm du lịch",
					Slug = "dia-diem-du-lich",
					Content = "Cung cấp thông tin về các địa điểm du lịch",
					CoverImgPath = "files/ImgNewsCate/Places-to-travel.jpg",
					CreatedDate = now
				}
			);
		}
	}
}
