using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class PurchaseFinalize
    {
        [Key] 
        public int Id { get; set; }
        [StringLength(100)]
        public string? purchaseCode { get; set; }
        public DateTime? creationDate { get; set; }

        public int Cart_Id { get; set; }
        [ForeignKey("Cart_Id")]
        public virtual Cart Cart { get; set; }
    }
}
