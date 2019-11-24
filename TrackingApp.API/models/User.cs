namespace TrackingApp.API.models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FullName { get; set; }
        public int Department { get; set; }
        public bool IsAdmin { get; set; }

    }
}