using System.ComponentModel.DataAnnotations;

namespace store_service.Models;

public class Shop
{
    [Key] 
    public Guid Id { get; set; }
    public string address { get; set; }
    public string telephone_number { get; set; }
    public string email { get; set; }
    public Storage Storage { get; set; }
    public List<Product> Products { get; set; } = new();
}