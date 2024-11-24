using App.Data.Entities.News;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
    public class AppNewsConfig : IEntityTypeConfiguration<AppNews>
    {
        public void Configure(EntityTypeBuilder<AppNews> builder)
        {
            builder.ToTable(DB.AppNews.TABLE_NAME);
            builder.HasKey(x => x.Id);

			builder.Property(s => s.Title)
				.HasMaxLength(DB.AppNews.TITLE_LENGTH)
				.IsRequired();

			builder.Property(s => s.Slug)
				.HasMaxLength(DB.AppNews.SLUG_LENGTH)
				.IsRequired();

			builder.Property(s => s.Content)
				.HasMaxLength(DB.AppNews.MAX_LENGTH);

			builder.Property(s => s.Published)
				.HasDefaultValue(DB.AppNews.PUBLIC_NEWS);

			builder.Property(s => s.CreatedDate)
				.IsRequired()
				.HasDefaultValueSql(DB.AppNews.DEFAULT_DATE);

			builder.Property(s => s.PublishedAt)
				.HasDefaultValue(DB.AppNews.DEFAULT_VALUE);

			builder.Property(s => s.Votes)
				.HasDefaultValue(DB.AppNews.COUNT);

			builder.Property(s => s.Views)
				.HasDefaultValue(DB.AppNews.COUNT);

			builder.Property(s => s.CoverImgPath)
				.IsRequired(false)
				.HasDefaultValue(DB.AppNews.DEFAULT_VALUE);

			// FK - AppCategoryNews
			builder.HasOne(s => s.NewsCategory)
				.WithMany(s => s.NewsNavigation)
				.HasForeignKey(s => s.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);

			// FK - AppUsers
			builder.HasOne(s => s.Users)
				.WithMany(s => s.AppNewsNavigation)
				.HasForeignKey(s => s.CreatedBy)
				.OnDelete(DeleteBehavior.NoAction);
		}
    }
}