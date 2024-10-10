using App.Data.Entities.Base;

namespace App.Data.Entities.User
{
    public class AppRolePermission : AppEntityBase
    {
        public int AppRoleId { get; set; }
        public int MstPermissionId { get; set; }

        public AppRole AppRole { get; set; }
        public MstPermission MstPermission { get; set; }
    }
}