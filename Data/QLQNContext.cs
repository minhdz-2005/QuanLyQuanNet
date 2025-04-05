using Microsoft.EntityFrameworkCore;

namespace QuanLyQuanNet.Models {
    public class QLQNContext : DbContext {
        public QLQNContext (DbContextOptions<QLQNContext> options) : base(options) {}
        
        public DbSet<Account> Account {get; set;}
        public DbSet<Computer> Computer {get; set;}
        public DbSet<LoginInfor> LoginInfor {get; set;}
        public DbSet<UsedInfor> UsedInfor {get; set;}
        public DbSet<User> User {get; set;}
    }
}