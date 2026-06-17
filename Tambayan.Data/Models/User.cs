using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tambayan.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string? ProfilePictureUrl { get; set; }

        // Navigation Properties
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
    
}
