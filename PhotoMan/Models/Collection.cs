namespace PhotoMan.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public required string Code { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime Created{ get; set; } = DateTime.UtcNow;
        public DateTime Updated{ get; set;} = DateTime.UtcNow;


        // Navigation properties
        public required User User { get; set; }
        public List<Photo>? Photos { get; set; }
        public List<CollectionPurchase>? CollectionPurchases { get; set; }
    }
}
