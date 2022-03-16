using Microsoft.AspNetCore.Mvc;
using store_service.Models;

namespace store_service.Controllers;

public class PersonController:Controller
{
    private StoreServiceContext db;

    public PersonController(StoreServiceContext context)
    {
        db = context;
    }
    public ActionResult create() 
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Person person)
    {

        db.Person.Add(person);
        db.SaveChanges();
        
        string message = "Created the record successfully";
              
        // To display the message on the screen
        // after the record is created successfully
        ViewBag.Message = message;     
              
        // write @Viewbag.Message in the created
        // view at the place where you want to
        // display the message
        return View(); 
        
    }
    
    
    
}