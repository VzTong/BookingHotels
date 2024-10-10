using App.Data.Entities.Base;

namespace App.Data.Entities.User
{
    public class MstPermission : AppEntityBase
    {
        public MstPermission()
        {
            AppRolePermissions = new HashSet<AppRolePermission>();
        }
        public string Code { get; set; }
        public string Table { get; set; }
        public string GroupName { get; set; }
        public string Desc { get; set; }

        public ICollection<AppRolePermission> AppRolePermissions { get; set; }
    }
}