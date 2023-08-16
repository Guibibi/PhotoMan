namespace PhotoMan.Models
{
 public class Photo
    {
        public int Id { get; set; }
        public int CollectionID { get; set; }
        public required string ImageUrl { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;

        // If we want to implement price per photo
        // public decimal Price { get; set; }

        // Navigation Properties
        public required Collection Collection { get; set; }
    }   
}
