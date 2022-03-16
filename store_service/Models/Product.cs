using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace store_service.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }
    [ForeignKey("Producer")]
    public Guid ProducerId { get; set; }
    public byte[]? ProductImage { get; set; }
    public Producer Producer { get; set; }
    public Category Category { get; set; }
    public List<Shop> Shops { get; set; } = new();
    public List<PersonOrder> Orders { get; set; } = new();
}