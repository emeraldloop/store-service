using AutoMapper;
using Newtonsoft.Json.Linq;

namespace store_service.Models.ClientModels;

public class PersoOrderProfile:Profile
{
    
    // public PersonOrderProfile() 
    // {
    //     CreateMap<JObject, List<PersonOrder>>().ConvertUsing<JObjectToPersonOrderListConverter>();
    //     var employeeMap =
    //         CreateMap<JToken, User>();
    //
    //     employeeMap.ForMember(x => x.Id, y => y.MapFrom(j => j.SelectToken(".Id")));
    //     employeeMap.ForMember(x => x.DisplayName,
    //         y => y.MapFrom(j => j.SelectToken(".LastName").ToString() + ", " + j.SelectToken(".FirstName").ToString()));
    //     employeeMap.ForMember(x => x.Gender, y => y.MapFrom(j => j.SelectToken(".Gender.FullName")));
    //
    //     employeeMap.ForMember(x => x.Login, y => y.MapFrom(j => j.SelectToken(".Login")));
    //     
    // }
}