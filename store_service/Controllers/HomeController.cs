using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using store_service.Models;

namespace store_service.Controllers;

public class HomeController : Controller
{
    
    private StoreServiceContext db;
    public HomeController(StoreServiceContext context)
    {
        db = context;
    }

    public IActionResult Index()
    {

        return View(db.Product);
    }
    
    /*[Authorize(Roles = "admin, user")]
    public IActionResult Index()
    {
        string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
        return Content($"ваша роль: {role}");
    }

    [Authorize(Roles = "admin")]
    public IActionResult About()
    {
        return Content("Вход только для администратора");
    }
    */
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}