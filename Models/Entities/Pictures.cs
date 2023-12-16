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
        public string pic { get; set; }
        public DateTime? creationDate { get; set; }

        public int? pub_id { get; set; }
        [ForeignKey("pub_id")]
        public virtual Pub? Pub { get; set; }
        public int? event_id { get; set; }
        [ForeignKey("event_id")]
        public virtual Events? Event { get; set; }
    }
}
