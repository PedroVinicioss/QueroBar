using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        public string? Image { get; set; }

    }
}
