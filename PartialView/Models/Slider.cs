using PartialView.Models.Common;

namespace PartialView.Models
{
    public class Slider:AuditEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ButtonLink { get; set; }
        public string? ButtonText { get; set; }
        public int Order { get; set; }
    }
}
