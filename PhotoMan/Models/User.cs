
namespace PhotoMan.Models
{
 public enum UserRole
    {
        Photographer,
        Client,
        Both
    }

    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required UserRole Role { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;

         // Navigation properties
        public required List<Collection>? Collections { get; set; }
        public List<CollectionPurchase>? Purchases { get; set; }
       
        }   
}
