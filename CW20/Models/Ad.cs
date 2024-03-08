using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace CW20.Models;

public class Ad
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    [MaxLength(1000)]
    public string Description { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public City City { get; set; }
    public int CityId { get; set; }
    public List<Picture> Pictures { get; set; }
    //public User User { get; set; }
    //[ForeignKey("User")]
    //public int UserId { get; set; }
    public List<Bookmark> UserBookmarks { get; set; }
}