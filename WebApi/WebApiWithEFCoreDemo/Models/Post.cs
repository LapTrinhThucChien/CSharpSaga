using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiWithEFCoreDemo.Models
{
    public class Post
    {
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string? Title { get; set; }

        [MaxLength(500)]
        [Required]
        public string Summary { get; set; }

        [Required]
        public string Content { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Slug { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? CategoryId { get; set; }

        public virtual PostCategory? Category { get; set; }
    }
}
