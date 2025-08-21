using System.ComponentModel.DataAnnotations;
using PartialView.Models.Common;

namespace PartialView.Models
{
    public class BookImage:BaseEntity
    {
        [Required]
        public string ImageUrl { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
