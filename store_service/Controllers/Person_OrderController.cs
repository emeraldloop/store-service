using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using store_service.Models;
using store_service.Models.ClientModels;
using store_service.Services.OrderService;
namespace store_service.Controllers;

[Route("api/orderscontroller")]
[ApiController]
public class PersonOrderController
{
    private readonly IOrderService _service;

    public PersonOrderController(IOrderService service)
    {
        _service = service;
    }
    [HttpPost]
    public async Task<JsonResult> MakeOrder(ClientOrder model)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientOrder, PersonOrder>()
                .ForMember(dest => dest.total_price, act => act.MapFrom(src => src.total))
        );
        var mapper = new Mapper(config);
        
        // Выполняем сопоставление
        PersonOrder order = mapper.Map<ClientOrder, PersonOrder>(model);
        
        try
        {
            var result = new JsonResult(await _service.MakeOrder(order));
            return result;
        }
        catch(Exception e)
        {
            return new JsonResult(e);
        }
        
    }
}