
using System.ComponentModel.DataAnnotations;

namespace CW20.Models;

public class User
{
    public int Id { get; set; }
    [MaxLength(20)]
    public string FisrtName { get; set; }
    [MaxLength(30)]
    public string LastName { get; set; }
    [MaxLength(100)]
    public string Email { get; set; }
    [MaxLength(10)]
    public string Password { get; set; }
    //public List<Ad> Ads { get; set; }
    public List<Bookmark> Bookmarks { get; set; }
}
