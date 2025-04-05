using QuanLyQuanNet.Models;

public class AccountService {
    private readonly QLQNContext _context;
    public AccountService (QLQNContext context) {
        _context = context;
    }

    public void Add(Account acc) {
        _context.Add(acc);
        _context.SaveChanges();
    }
    public void Update(int id, Account acc) {
        var existing = _context.Account.Find(id);

        if(existing != null) {
            existing.UserId = acc.UserId;
            existing.Money = acc.Money;

            _context.SaveChanges();
        }
    }
    public void Delete(int id) {
        var existing = _context.Account.Find(id);
        
        if(existing != null) {
            _context.Account.Remove(existing);
            _context.SaveChanges();
        }
    }
    public Account GetById(int id) {
        Account acc = new Account();
        
        var existing = _context.Account.Find(id);

        if(existing != null) {
            acc.Id = existing.Id;
            acc.UserId = existing.UserId;
            acc.Money = existing.Money;
        }
        return acc;
    }
    public List<Account> GetAll() {
        return _context.Account.ToList();
    }
}