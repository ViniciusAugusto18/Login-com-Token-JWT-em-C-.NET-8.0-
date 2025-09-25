namespace WebApplication1.DTOs
{
    public class UserDTO
    {
        public Guid id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Tenent { get; set; } = string.Empty;
    }
}
