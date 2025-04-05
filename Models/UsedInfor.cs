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

    public UsedInfor() {}
    public UsedInfor(int userId, int computerId, TimeSpan usedTime) {
        UserId = userId;
        ComputerId = computerId;
        UsedTime = usedTime;
    }
    public UsedInfor(int id, int userId, int computerId, TimeSpan usedTime) {
        Id = id;
        UserId = userId;
        ComputerId = computerId;
        UsedTime = usedTime;
    }
}