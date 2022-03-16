using System.Text.Json.Nodes;
using AutoMapper;
using AutoMapper.Internal.Mappers;
using Newtonsoft.Json.Linq;

namespace store_service.Models.ClientModels;

public class JObjectToPersonOrderListConverter 
{
    public List<PersonOrder> Convert(JObject source, List<PersonOrder> destination, ResolutionContext context)
    {
             
        var PersonOrderList = new List<PersonOrder>();
        var tokenCountItems = source.SelectTokens("Items").Children().Count();
        for (int i = 0; i < tokenCountItems; i++)
        {
            var token = source.SelectToken($"Items[{i}]");
            var result = new PersonOrder();
 
            if (token != null)
            {
                result = context.Mapper.Map<JToken, PersonOrder>(token);
            }
            PersonOrderList.Add(result);
        }
        return PersonOrderList;
    }
}
