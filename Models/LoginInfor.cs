using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class LoginInfor {
    public int Id {get; set; }
    [ForeignKey("Account")]
    public int AccountId {get; set; }
    [Required]
    public string Name {get; set;}
    [Required]
    public string Password {get; set;}
}