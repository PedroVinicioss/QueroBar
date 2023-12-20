using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Image { get; set; }
    }
}
