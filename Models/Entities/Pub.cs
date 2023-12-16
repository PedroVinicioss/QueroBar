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
        public string cnpj { get; set; }
        [StringLength(50)]
        public string? pixKey { get; set; }
        [StringLength (50)]
        public string? zipCode { get; set; }
        [StringLength (50)]
        public string? state { get; set; }
        [StringLength(50)]
        public string? city { get; set;}
        [StringLength (50)]
        public string? neighborhood { get; set; }
        [StringLength (50)]
        public string? road { get; set; }
        [StringLength (50)]
        public int? number { get; set; }
        public DateTime? openingTime { get; set; }
        public DateTime? closingTime { get; set; }
        public DateTime? creationDate { get; set; }

        public virtual List<Pictures> Pictures { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
    }
}
