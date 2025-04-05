using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Computer {
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name {get; set; }
    public bool Status {get; set; }
    [Precision(10, 2)]
    public decimal Cost {get; set; }

    public Computer () {}
    public Computer (string name, bool status, decimal cost) {
        Name = name;
        Status = status;
        Cost = cost;
    }
    public Computer (int id, string name, bool status, decimal cost) {
        Id = id;
        Name = name;
        Status = status;
        Cost = cost;
    }
}