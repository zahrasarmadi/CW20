using System.ComponentModel.DataAnnotations.Schema;

namespace CW20.Models;

public class Bookmark
{
    public int Id { get; set; }
    public User User { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public Ad Ad { get; set; }
    [ForeignKey("Ad")]
    public int AdId { get; set; }
}
