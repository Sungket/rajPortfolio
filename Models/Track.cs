using System.ComponentModel.DataAnnotations;

namespace RajPortfolio.Models;

public class Track
{
    public int id { get; set; }
    [StringLength(100, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }
    [Display(Name = "Length")]

    public double length { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    public string Genre { get; set; } 
}