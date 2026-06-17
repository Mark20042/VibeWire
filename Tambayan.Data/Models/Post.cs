using System.ComponentModel.DataAnnotations;

namespace Tambayan.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public int NoReports { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }


        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User User { get; set; } = null!;

        public virtual ICollection<PostImage> Images { get; set; } = new List<PostImage>();
    }
}
