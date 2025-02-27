using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeafLedgure.Models.Domain
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string GenreName { get; set; }
        public List<Book> Books { get; set; }
    }
}
