using App.Data.Entities.Base;
using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.service;
using App.Data.Entities.User.Staff;

namespace App.Data.Entities.User
{
    public class AppUser : AppEntityBase
    {
        public AppUser()
        {
            AppNewsNavigation = new HashSet<AppNews>();
			Comments = new HashSet<AppComment>();
            OwnerOrders = new HashSet<AppOrder>();
            VerifiedOrders = new HashSet<AppOrderDetail>();
            StaffPayrolls = new HashSet<AppPayroll>();
            StaffWorkSchedules = new HashSet<AppWorkSchedule>();
        }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string? Avatar { get; set; }
        public DateTime? BlockedTo { get; set; }
        public int? BlockedBy { get; set; }
        public int? CitizenId { get; set; }
        public string? Passport { get; set; }
        public string? Permanent { get; set; }
        public int? BranchId { get; set; }
        public int? AppRoleId { get; set; }

        virtual public AppBranchHotel Branch { get; set; }
        virtual public AppRole AppRole { get; set; }
        virtual public ICollection<AppNews> AppNewsNavigation { get; set; }
        virtual public ICollection<AppComment> Comments { get; set; }
        virtual public ICollection<AppOrder> OwnerOrders { get; set; }
        virtual public ICollection<AppOrderDetail> VerifiedOrders { get; set; }
        virtual public ICollection<AppPayroll> StaffPayrolls { get; set; }
        virtual public ICollection<AppWorkSchedule> StaffWorkSchedules { get; set; }
    }
}