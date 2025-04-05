using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Account {
    public int Id {get; set; }
    [Required]
    [ForeignKey("User")]
    public int UserId {get; set; }
    [Precision(18,2)]
    public decimal Money {get; set; }
    
}