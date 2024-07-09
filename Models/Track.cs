using System.ComponentModel.DataAnnotations;

namespace RajPortfolio.Models;

public class Track
{
    public int id { get; set; }
    public string? Title { get; set; }
    [Display(Name = "Length")]
    public double length { get; set; }
}