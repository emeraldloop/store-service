using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace store_service.Controllers;

public class ProducerController:Controller
{
    private StoreServiceContext db;

    public ProducerController(StoreServiceContext context)
    {
        db = context;
    }
    
    public async Task<IActionResult> Index()
    {
        return View(await db.Producer.ToListAsync());
    }
    
    
}