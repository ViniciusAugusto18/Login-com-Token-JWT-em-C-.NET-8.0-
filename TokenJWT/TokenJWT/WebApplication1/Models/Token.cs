namespace WebApplication1.Models
{
    public class Token
    {
        public object AccessToken { get; set; } = string.Empty;
        public object RefreshToken { get; set; } = string.Empty;     
    }
}
