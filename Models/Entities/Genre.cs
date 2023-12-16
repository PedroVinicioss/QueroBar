using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? name { get; set; }
        [Required]
        [StringLength(50)]
        public string? description { get; set; }
        public string? image { get; set; }

    }
}
