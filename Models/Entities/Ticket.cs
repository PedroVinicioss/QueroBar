using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace QueroBar.Models.Entities
{
    public class Ticket
    {
        [Key] 
        public int Id { get; set; }

        [StringLength(100)]
        public string? VoucherCode { get; set; }

        public int? Event_Id { get; set; }
        [ForeignKey("Event_Id")]
        public virtual Events? Event { get; set; }

    }
}
