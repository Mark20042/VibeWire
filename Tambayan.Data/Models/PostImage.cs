using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tambayan.Data.Models
{
    public class PostImage
    {
        [Key]
        public int PostImageId { get; set; }

       
        public string ImageUrl { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; } = DateTime.UtcNow;


        // Foreign Key
        public int PostId { get; set; }


        // Navigation Property
        public virtual Post Post { get; set; } = null!;
    }
}
