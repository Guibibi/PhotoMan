using System.ComponentModel.DataAnnotations;

namespace PhotoMan.Data.Models
{
    public class PhotoCollection
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;


        // Navigation properties
        [Required]
        public User User { get; set; }
        public List<Photo>? Photos { get; set; }
        public List<CollectionPurchase>? CollectionPurchases { get; set; }
    }
}
