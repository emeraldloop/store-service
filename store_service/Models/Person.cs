using System.ComponentModel.DataAnnotations;

namespace store_service.Models;

public class Person
{
    [Key]
    public Guid Id { get; set; }
    public string Password{ get; set; }
    public string Email{ get; set; }
    public int? RoleId { get; set; }
    public Role Role { get; set; }
    public List<PersonOrder> Orders { get; set; } = new();
}