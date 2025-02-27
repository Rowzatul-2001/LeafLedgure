using LeafLedgure.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeafLedgure.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public  int Id { get; set; }
        [Required]
        public int OrderId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Double UnitPrice { get; set; }

        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
