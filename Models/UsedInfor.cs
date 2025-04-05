using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UsedInfor {
    public int Id { get; set;}
    [ForeignKey("User")]
    public int UserId {get; set; }
    [ForeignKey("Computer")]
    public int ComputerId { get; set; }
    [Required]
    public TimeSpan UsedTime {get; set; }
}