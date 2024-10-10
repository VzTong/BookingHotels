using App.Data.Entities.News;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
	public class AppCategoryNewsConfig : IEntityTypeConfiguration<AppCategoryNews>
	{
		public void Configure(EntityTypeBuilder<AppCategoryNews> builder)
		{
			builder.ToTable(DB.AppCategoryNews.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(DB.AppCategoryNews.TITLE_LENGTH);

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppCategoryNews.SLUG_LENGTH);

			builder.Property(x => x.Content)
				.HasMaxLength(DB.AppCategoryNews.MAX_LENGTH);

			builder.Property(x => x.CoverImgPath)
				.HasMaxLength(DB.AppCategoryNews.COVER_IMG_LENGTH);

			builder.Property(x => x.CreatedDate)
				.HasDefaultValueSql(DB.AppCategoryNews.DEFAULT_DATE);
		}
	}
}