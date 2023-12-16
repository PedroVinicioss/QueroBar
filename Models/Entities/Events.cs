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
        public string name { get; set; }
        public DateTime? openingTime { get; set; }
        public DateTime? closingTime { get; set; }
        public DateTime? createdTime { get; set; }
        public int? capacity { get; set; }
        public int? ticketsSold { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Artist>? Artists { get; set; }
        public int Pub_Id { get; set; }
        [ForeignKey("Pub_Id")]
        public virtual Pub Pub { get; set; }

    }
}
