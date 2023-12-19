using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Name { get; set; 
        }
        [Required]
        [StringLength(50)]
        public string? Description { get; set; }

        public string? Image { get; set; }

    }
}
