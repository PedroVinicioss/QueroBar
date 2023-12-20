using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class Pub
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? CNPJ { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? PixKey { get; set; }

        [StringLength (50)]
        public string? ZipCode { get; set; }

        [StringLength (50)]
        public string? State { get; set; }

        [StringLength(50)]
        public string? City { get; set;}

        [StringLength (50)]
        public string? Neighborhood { get; set; }

        [StringLength (50)]
        public string? Road { get; set; }

        [StringLength (50)]
        public int? Number { get; set; }

        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual List<Pictures>? Pictures { get; set; }

        public virtual List<Icon>? Icons { get; set; }

        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User? User { get; set; }
    }
}
