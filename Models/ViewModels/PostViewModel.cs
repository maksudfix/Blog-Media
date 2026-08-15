using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogMedia.Models.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; } = new();
        [ValidateNever]
        public IEnumerable<SelectListItem> Categories{ get; set; } = Enumerable.Empty<SelectListItem>();
        public IFormFile  FeatureImage { get; set; }
    }
}
