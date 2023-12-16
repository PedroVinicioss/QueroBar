using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.Entities
{
    public class Artist
    {
        [Key] 
        public int Id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        public DateTime? creationDate { get; set; }

    }
}
