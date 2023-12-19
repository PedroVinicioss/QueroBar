using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class CartProduct
    {
        [Key]
        public int Id { get; set; }

        public int? User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User? User { get; set; }

        public int? Event_Id { get; set; }
        [ForeignKey("Event_Id")]
        public virtual Events? Event { get; set; }

        public int? Ticket_Id { get; set; }
        [ForeignKey("Ticket_Id")]
        public virtual Ticket? Ticket { get; set; }

        [NotMapped]
        public string? Valor { get; set; }
    }
}
