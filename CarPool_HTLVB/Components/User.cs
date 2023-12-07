namespace CarPool_HTLVB.Components
{
    public interface IUser
    {
        public int? UserID { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? SchoolClass { get; set; }
        public bool? Teacher { get; set; }
        public string? MobileNumber { get; set; }
    }
    public class User : IUser
    {
        public int? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? SchoolClass { get; set; }
        public bool? Teacher { get; set; }
        public string? MobileNumber { get; set; }
    }
    public class CurUser : IUser
    {
        public int? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? SchoolClass { get; set; }
        public bool? Teacher { get; set; }
        public string? MobileNumber { get; set; }
    }
}
