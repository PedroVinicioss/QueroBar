using QueroBar.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.ViewModels
{
    public class PerfilViewModel
    {
        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }
        public IFormFile? File { get; set; }

        public string? Phone { get; set; }

        public string? Error { get; set; }

        public int? Membership { get; set; }

        public int Id { get; set; }

        [StringLength(50)]
        public string? CNPJ { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? PixKey { get; set; }

        [StringLength(50)]
        public string? ZipCode { get; set; }

        [StringLength(50)]
        public string? State { get; set; }

        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? Neighborhood { get; set; }

        [StringLength(50)]
        public string? Road { get; set; }

        [StringLength(50)]
        public int? Number { get; set; }

        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual List<Pictures>? Pictures { get; set; }

        public virtual List<Icon>? Icons { get; set; }
    }
}
