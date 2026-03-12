using AdvancedEntityFrameWorkCore.Domain.Common;

namespace AdvancedEntityFrameWorkCore.Domain;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public Guid CategoryId {  get; set; }
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
    public Guid? CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }
}
