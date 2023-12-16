using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.Entities
{
    public class Administrador
    {
        [Key]
        public int Id { get; set; }
        public DateTime? creationDate { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
    }
}
