using System.ComponentModel.DataAnnotations;

namespace CW20.Models;

public class City
{
    public int Id { get; set; }
    [MaxLength(20)]
    public string Name { get; set; }
   // public string Province { get; set; }
}