using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("TbUsers")]
    public class Users
    {
        [Key]
        public Guid Id { get;  private set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Tenent { get; set; } = string.Empty;
        
    }
}
