using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class Pictures
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string? Pic { get; set; }
        public DateTime? CreationDate { get; set; }

        public int? Pub_Id { get; set; }
        [ForeignKey("Pub_Id")]
        public virtual Pub? Pub { get; set; }
        public int? Event_Id { get; set; }
        [ForeignKey("Event_Id")]
        public virtual Events? Event { get; set; }
    }
}
