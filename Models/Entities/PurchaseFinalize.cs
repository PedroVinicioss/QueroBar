using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class PurchaseFinalize
    {
        [Key] 
        public int Id { get; set; }

        [StringLength(100)]
        public string? PurchaseCode { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? Cart_Id { get; set; }
        [ForeignKey("Cart_Id")]
        public virtual Cart? Cart { get; set; }
    }
}
