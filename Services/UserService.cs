using QuanLyQuanNet.Models;

public class UserService {
    private readonly QLQNContext _context;
    public UserService(QLQNContext context) {
        _context = context;
    }
    public void Add(User u) {
        _context.User.Add(u);
        _context.SaveChanges();
    }
    public void Update(int id, User u) {
        var existing = _context.User.Find(id);

        if(existing != null) {
            existing.Name = u.Name;
            existing.PhoneNumber = u.PhoneNumber;
            existing.AccountId = u.AccountId;

            _context.SaveChanges();
        }
    }
    public void Delete(int id) {
        var existing = _context.User.Find(id);

        if(existing != null) {
            _context.User.Remove(existing);
            _context.SaveChanges();
        }
    }
    public User GetById(int id) {
        User u = new User();

        var existing = _context.User.Find(id);

        if(existing != null) {
            u.Id = existing.Id;
            u.Name = existing.Name;
            u.PhoneNumber = existing.PhoneNumber;
            u.AccountId = existing.AccountId;
        }
        return u;
    }
    public List<User> GetAll() {
        return _context.User.ToList();
    }
}