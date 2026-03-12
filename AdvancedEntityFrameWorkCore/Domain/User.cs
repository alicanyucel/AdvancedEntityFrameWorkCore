using AdvancedEntityFrameWorkCore.Domain.Common;

namespace AdvancedEntityFrameWorkCore.Domain;

public class User:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<Product> CreatedProducts { get; set; } = new List<Product>();
}
