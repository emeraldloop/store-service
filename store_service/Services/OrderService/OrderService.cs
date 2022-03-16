using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using store_service.Models;

namespace store_service.Services.OrderService;

public class OrderService:IOrderService
{
    private readonly StoreServiceContext _context;
    
    public OrderService(StoreServiceContext ctx)
    {
        _context = ctx;
    }
    
    public async Task<PersonOrder> MakeOrder(PersonOrder order)
    {
        await _context.Person_Order.AddAsync(order);
        try
        {
            await _context.SaveChangesAsync();
            return order;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: when update db context, reason: {0}", e.Message);
            
            throw new DbUpdateException();
        }
    }

    public async Task<List<PersonOrder>> GetAllOrders(Guid personId)
    {
        return await _context.Person_Order.Where(o => o.person_id.Equals(personId)).ToListAsync();
    }
}