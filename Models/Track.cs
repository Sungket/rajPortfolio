using System.ComponentModel.DataAnnotations;

namespace RajPortfolio.Models;

public class Track
{
    public int id { get; set; }
    public string? Title { get; set; }
    public double length { get; set; }
}