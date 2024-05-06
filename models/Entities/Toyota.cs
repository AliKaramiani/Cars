using System.ComponentModel.DataAnnotations;

public class Toyota
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string  color { get; set; }
}