using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public float? Total { get; set; }

        public float? SubTotal { get; set; }

        [NotMapped]
        public string? TotalFormatted { get; set; }

        public int? User_Id { get; set; }

        public int? Status { get; set; }


        [ForeignKey("User_Id")]
        public virtual User? User { get; set; }
        public virtual List<CartProduct>? Products { get; set; }
        public virtual List<PurchaseFinalize>? Finalizes { get; set; }
    }
}
