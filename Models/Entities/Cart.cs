using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public float? sub_total { get; set; }

        public float? total { get; set; }

        [NotMapped]
        public string? total_formatted { get; set; }

        public int? User_id { get; set; }

        public int? Status { get; set; }

        [ForeignKey("User_id")]
        public virtual User? User { get; set; }
        public virtual List<CartProduct>? Products { get; set; }
        public virtual List<PurchaseFinalize>? Finalizes { get; set; }
    }
}
