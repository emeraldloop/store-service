using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using store_service.Models.ClientModels;
using AutoMapper.Internal.Mappers;
using AutoMapper;
using Newtonsoft.Json.Linq;

namespace store_service.Models;

public class PersonOrder
{
    [Key]
    public Guid Id{ get; set; }
    public DateTime order_date{ get; set; }
    [ForeignKey("Person")]
    public Guid person_id{ get; set; }
    public decimal total_price{ get; set; }
    public Person Person{ get; set; }
    public List<Product> Products { get; set; } = new();

    public PersonOrder()
    {
        Id=Guid.NewGuid();
        order_date=DateTime.Now;
        

    }


    /*
     public PersonOrder(Guid personId, decimal totalPrice,List<Product> products)
    {
        Id = Guid.NewGuid();
        order_date = DateTime.Now;
        person_id = personId;
        total_price = totalPrice;
        Products = products;
    }
     */
}