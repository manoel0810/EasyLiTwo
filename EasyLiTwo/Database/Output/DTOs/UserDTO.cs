namespace EasyLiTwo.Database.Output.DTOs
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string SHA { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public int UserState { get; set; }
    }
}
