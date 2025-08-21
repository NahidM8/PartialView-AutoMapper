using PartialView.Models.Common;

namespace PartialView.Models
{
    public class Slider:BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ButtonLink { get; set; }
        public string? ButtonText { get; set; }
    }
}
