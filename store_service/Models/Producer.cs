using System.ComponentModel.DataAnnotations;

namespace store_service.Models;

public class Producer
{
     [Key]
     public Guid Id{ get; set; }
     public string ProducerName{ get; set; }
     public List<Product> Products { get; set; }
}