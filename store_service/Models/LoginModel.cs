using System.ComponentModel.DataAnnotations;

namespace store_service.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Не указан Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}