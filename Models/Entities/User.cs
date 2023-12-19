using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        [PasswordPropertyText]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        [Phone]
        public string? phone { get; set; }

        public string? pic { get; set; }
        
        [EnumDataType(typeof(UserType))]
        public UserType type { get; set; }
        public enum UserType { administrador = 0, pub = 1, client = 2}

        public DateTime? creationDate { get; set; }

    }
}
