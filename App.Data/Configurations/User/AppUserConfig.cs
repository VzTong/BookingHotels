using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User
{
	public class AppUserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.ToTable(DB.AppUser.TABLE_NAME);
			builder.HasKey(x => x.Id);

			// Tên đăng nhập là varchar, bắt buộc & không trùng lặp
			builder.Property(x => x.Username)
				.HasMaxLength(DB.AppUser.USERNAME_LENGTH)
				.IsUnicode(false)   // varchar (không chứa unicode)
				.IsRequired();
			builder.HasIndex(x => x.Username).IsUnique();

			builder.Property(x => x.Address)
				.HasMaxLength(DB.AppUser.ADDRESS_LENGTH);

			builder.Property(x => x.Avatar)
				.HasMaxLength(DB.AppUser.AVATAR_LENGTH);

			builder.Property(x => x.Email)
				.HasMaxLength(DB.AppUser.EMAIL_LENGTH)
				.IsUnicode(false);

			builder.Property(x => x.FullName)
				.HasMaxLength(DB.AppUser.FULLNAME_LENGTH);

			builder.Property(x => x.PasswordHash)
				.HasMaxLength(DB.AppUser.PWD_LENGTH);

			builder.Property(x => x.PasswordSalt)
				.HasMaxLength(DB.AppUser.PWD_LENGTH);

			builder.Property(x => x.PhoneNumber1)
				.HasMaxLength(DB.AppUser.PHONE_LENGTH)
				.IsUnicode(false);

			builder.Property(x => x.PhoneNumber2)
				.HasMaxLength(DB.AppUser.PHONE_LENGTH)
				.IsUnicode(false);

			builder.Property(x => x.CitizenId)
				.HasMaxLength(DB.AppUser.CITIZENID_LENGTH);

			builder.Property(x => x.Passport)
				.HasMaxLength(DB.AppUser.PASSPORT_LENGTH);

			builder.Property(x => x.Permanent)
				.HasMaxLength(DB.AppUser.PERMANENT_LENGTH);

			// FK - AppBranchHotel
			builder.HasOne(x => x.Branch)
				.WithMany(x => x.Users)
				.HasForeignKey(x => x.BranchId)
				.OnDelete(DeleteBehavior.NoAction);

			// FK - AppRole
			builder.HasOne(x => x.AppRole)
				.WithMany(x => x.AppUsers)
				.HasForeignKey(x => x.AppRoleId);
			//.OnDelete(DeleteBehavior.NoAction);
		}
	}
}