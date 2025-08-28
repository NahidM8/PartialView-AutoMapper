using System.ComponentModel.DataAnnotations;
using PartialView.Models.Common;

namespace PartialView.Models
{
    public class Author: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
