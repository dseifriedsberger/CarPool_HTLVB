namespace CarPool_HTLVB.Components
{
    public interface IUser
    {
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? SchoolClass { get; set; }
    }
    public class User : IUser
    {
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? SchoolClass { get; set; }
    }
    public class CurUser : IUser
    {
        public string? EMailAddress { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? SchoolClass { get; set; }

    }
}
