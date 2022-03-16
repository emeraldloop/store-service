using store_service.Models;

namespace store_service.Services.OrderService;

public interface IOrderService
{
    public Task<PersonOrder> MakeOrder(PersonOrder order);
    public Task<List<PersonOrder>> GetAllOrders(Guid personId);
}