using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Actor
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }
    public string? Gender { get; set; }
}