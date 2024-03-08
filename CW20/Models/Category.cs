using System.ComponentModel.DataAnnotations;

namespace CW20.Models;

public class Category
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public List<Ad> Ads { get; set; }
}