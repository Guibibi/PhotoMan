namespace PhotoMan.Models
{
  public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }
    public class CollectionPurchase
    {
        public int Id { get; set; }
        public required string ClientId { get; set; }
        public int CollectionId { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
        public PaymentStatus PaymentStatus { get; set; }

        // Navigation properties
        public required User Client { get; set; }
        public required PhotoCollection Collection { get; set; }
    }
}
