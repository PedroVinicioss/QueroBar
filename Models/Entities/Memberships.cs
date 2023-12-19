using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Memberships
    {
        [Key]
        public int Id { get; set; }
        [StringLength(75)]
        public string name { get; set; }
        public string? cor { get; set; }

        [StringLength(250)]
        public string? description { get; set; }
    }
}
