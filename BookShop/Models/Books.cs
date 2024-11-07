using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Books
    {
        [Key]
        public Guid BookId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Genre { get; set; }

        public int Stock { get; set; }
    }
}
