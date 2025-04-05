using QuanLyQuanNet.Models;

public class LoginInforService {
    private readonly QLQNContext _context;
    public LoginInforService(QLQNContext context) {
        _context = context;
    }
    public void Add(LoginInfor i) {
        _context.LoginInfor.Add(i);
        _context.SaveChanges();
    }
    public void Update(int id, LoginInfor i) {
        var existing = _context.LoginInfor.Find(id);

        if(existing != null) {
            existing.AccountId = i.AccountId;
            existing.Name = i.Name;
            existing.Password = i.Password;

            _context.SaveChanges();
        }
    }
    public void Delete(int id) {
        var existing = _context.LoginInfor.Find(id);

        if( existing != null ) {
            _context.LoginInfor.Remove(existing);
            _context.SaveChanges();
        }
    }
    public LoginInfor GetById(int id) {
        LoginInfor i = new LoginInfor();

        var existing = _context.LoginInfor.Find(id);

        if(existing != null) {
            i.Id = existing.Id;
            i.AccountId = existing.AccountId;
            i.Name = existing.Name;
            i.Password = existing.Password;
        }
        return i;
    }
    public List<LoginInfor> GetAll() {
        return _context.LoginInfor.ToList();
    }
}