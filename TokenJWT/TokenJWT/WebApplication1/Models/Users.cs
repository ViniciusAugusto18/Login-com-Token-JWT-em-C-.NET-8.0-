using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("TbUsers")]
    public class Users
    {
        [Key]
        public Guid Id { get;  private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public string Tenent { get; private set; }

    }
}
