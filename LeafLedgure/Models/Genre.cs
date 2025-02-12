using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeafLedgure.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string GnereName { get; set; }
        public List<Book>Books { get; set; }
    }
}
