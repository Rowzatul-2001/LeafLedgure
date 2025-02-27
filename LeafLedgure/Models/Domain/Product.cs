using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeafLedgure.Models.Domain
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public int TotalPages { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int Publisher { get; set; }
        [Required]
        public int GenreId { get; set; }
    }
}
