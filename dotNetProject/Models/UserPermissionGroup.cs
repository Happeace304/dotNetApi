namespace dotNetProject.Models
{
    public class UserPermissionGroup
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PermissionGroupID { get; set; }
        public virtual User User { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
        public bool IsDisabled { get; set; }
    }
}