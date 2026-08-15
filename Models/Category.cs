using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace BlogMedia.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name must require")]
        [MaxLength(100, ErrorMessage = "Category Name can not exceed 100 characters.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
