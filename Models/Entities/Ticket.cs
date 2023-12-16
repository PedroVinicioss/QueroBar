using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace QueroBar.Models.Entities
{
    public class Ticket
    {
        [Key] 
        public int Id { get; set; }
        public float? price { get; set; }
        [StringLength(100)]
        public string? voucherCode { get; set; }
        public int Event_id { get; set; }
        [ForeignKey("Event_id")]
        public virtual Events? Event { get; set; }

    }
}
