namespace CW20.Models;

public class Picture
{
    public int Id { get; set; }
    public string Address { get; set; }
    public Ad Ad { get; set; }
    public int AdId { get; set; }
    public string Alt { get; set; }
}