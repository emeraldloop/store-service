using System.ComponentModel.DataAnnotations;

namespace store_service.Models;
public class Role
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Person> Persons { get; set; }
    public Role()
    {
        Persons = new List<Person>();
    }
}