using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User {
    public int Id {get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name {get; set; }
    [MaxLength(15)]
    public string? PhoneNumber {get; set; }
    [ForeignKey("Account")]
    public int AccountId {get; set; }

    public User() {}
    public User (string name, string phoneNumber, int accountId) {
        Name = name;
        PhoneNumber = phoneNumber;
        AccountId = accountId;
    }
    public User (int id, string name, string phoneNumber, int accountId) {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        AccountId = accountId;
    }
}