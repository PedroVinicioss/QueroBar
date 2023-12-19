using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Memberships
    {
        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string? Name { get; set; }

        public string? Color { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }
    }
}
