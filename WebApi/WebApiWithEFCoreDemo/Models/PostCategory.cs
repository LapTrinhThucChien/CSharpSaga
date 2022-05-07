using System.ComponentModel.DataAnnotations;

namespace WebApiWithEFCoreDemo.Models
{
    public class PostCategory
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Slug { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual List<Post>? Posts { get; set; }
    }
}
