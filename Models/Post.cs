using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogMedia.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title must require")]
        [MaxLength(400, ErrorMessage = "Title can not exceed 400 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content must require")]
        [MaxLength(500000, ErrorMessage = "Content can not exceed 500000 characters.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Author must require")]
        [MaxLength(100, ErrorMessage = "Author Name can not exceed 100 characters.")]
        public string Author { get; set; }
        [ValidateNever]
        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [ForeignKey("Category")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public ICollection<Comment>? Comments { get; set; }
    }
}
