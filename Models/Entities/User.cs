using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace QueroBar.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        [PasswordPropertyText]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        [Phone]
        public string? Phone { get; set; }

        public string? Pic { get; set; }
        
        [EnumDataType(typeof(UserStatus))]
        public UserStatus Status { get; set; }
        public enum UserStatus { Inativo = 0, Ativo = 1 }

        public int? Membership_Id { get; set; }
        [ForeignKey("Membership_Id")]
        public virtual Memberships? Membership { get; set; }

        public DateTime? CreationDate { get; set; }

        public string? Role { get; set; }
    }
}
