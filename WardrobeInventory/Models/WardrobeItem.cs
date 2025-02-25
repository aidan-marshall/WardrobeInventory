using WardrobeInventory.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeInventory.Models;

public class WardrobeItem
{
public int Id { get; set; }
public string Name { get; set; }
public ItemCategory Category { get; set; }
public string Brand { get; set; }
public string Color { get; set; }
public string Material { get; set; }
public string Size { get; set; }
public ItemCondition Condition { get; set; }
public string StorageLocation { get; set; }
public byte[]? Image { get; set; }
[DataType(DataType.Currency)]
[Column(TypeName = "decimal(18, 2)")]
public decimal Price { get; set; }
}
