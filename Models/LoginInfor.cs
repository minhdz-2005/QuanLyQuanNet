using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class LoginInfor {
    public int Id {get; set; }
    [ForeignKey("Account")]
    public int AccountId {get; set; }
    [Required]
    public string? Name {get; set;}
    [Required]
    public string? Password {get; set;}

    public LoginInfor() {}
    public LoginInfor(int accountId, string name, string password) {
        AccountId = accountId;
        Name = name;
        Password = password;
    }
    public LoginInfor(int id, int accountId, string name, string password) {
        Id = id;
        AccountId = accountId;
        Name = name;
        Password = password;
    }
}