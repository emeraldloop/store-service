namespace store_service.Models.ClientModels;

public class ClientOrder
{
    public Guid Id { get; set; }
    public decimal total { get; set; }
    public List<Product> Products { get; set; }
}