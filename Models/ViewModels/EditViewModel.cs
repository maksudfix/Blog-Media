using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlogMedia.Models;

namespace BlogMedia.Models.ViewModels
{
    public class EditViewModel
    {
        public Post Post { get; set; } = new();

        [ValidateNever]
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        [ValidateNever]
        public IFormFile? FeatureImage { get; set; }
    }
}