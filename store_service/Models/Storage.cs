using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace store_service.Models;

public class Storage
{
    [Key]
    [ForeignKey("Shop")]
    public Guid Id { get; set; }
    public string adress { get; set; }
    public int capacity { get; set; }
    public Shop Shop { get; set; }
}