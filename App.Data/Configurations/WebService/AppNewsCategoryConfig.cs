using App.Data.Entities.News;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
	public class AppNewsCategoryConfig : IEntityTypeConfiguration<AppNewsCategory>
	{
		public void Configure(EntityTypeBuilder<AppNewsCategory> builder)
		{
			builder.ToTable(DB.AppNewsCategory.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(DB.AppNewsCategory.TITLE_LENGTH);

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppNewsCategory.SLUG_LENGTH);

			builder.Property(x => x.Content)
				.HasMaxLength(DB.AppNewsCategory.MAX_LENGTH);

			builder.Property(x => x.CoverImgPath)
				.HasMaxLength(DB.AppNewsCategory.COVER_IMG_LENGTH);

			builder.Property(x => x.CreatedDate)
				.HasDefaultValueSql(DB.AppNewsCategory.DEFAULT_DATE);
		}
	}
}