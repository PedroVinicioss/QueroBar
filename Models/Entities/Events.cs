using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace QueroBar.Models.Entities
{
    public class Events
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public DateTime? CreatedTime { get; set; }

        public int? Capacity { get; set; }
        public int? TicketsSold { get; set; }

        public virtual List<Genre>? Genres { get; set; }
        public virtual List<Ticket>? Tickets { get; set; }
        public virtual List<Artist>? Artists { get; set; }

        public int Pub_Id { get; set; }
        [ForeignKey("Pub_Id")]
        public virtual Pub? Pub { get; set; }

    }
}
