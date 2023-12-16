using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class CartProduct
    {
        [Key]
        public int Id { get; set; }

        public int? User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual User? User { get; set; }

        public int? Event_id { get; set; }
        [ForeignKey("Event_id")]
        public virtual Events? Event { get; set; }

        public int? Ticket_id { get; set; }
        [ForeignKey("Ticket_id")]
        public virtual Ticket? Ticket { get; set; }

        [NotMapped]
        public string? Valor { get; set; }
    }
}
