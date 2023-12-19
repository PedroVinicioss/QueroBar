using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

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
        
        [EnumDataType(typeof(UserStatus))]
        public UserStatus status { get; set; }
        public enum UserStatus { Inativo = 0, Ativo = 1}

        public virtual Memberships? Membership { get; set; }

        public DateTime? creationDate { get; set; }

    }
}
