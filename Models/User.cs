using System.ComponentModel.DataAnnotations;

namespace ApiAuth.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        
        public string UserName { get; set; }

        public string Password { get; set; }

        public string? Role { get; set; }

    }
}
