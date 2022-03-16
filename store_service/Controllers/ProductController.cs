using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using store_service.Models;


namespace store_service.Controllers;

public class ProductController:Controller
{
    private StoreServiceContext db;

    public ProductController(StoreServiceContext context)
    {
        db = context;
    }
    public async Task<IActionResult> Index()
    {
        return View(await db.Product.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        db.Product.Add(product);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    
}