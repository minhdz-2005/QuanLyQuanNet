using QuanLyQuanNet.Models;

public class UsedInforService {
    private readonly QLQNContext _context;
    public UsedInforService(QLQNContext context) {
        _context = context;
    }
    public void Add(UsedInfor u) {
        _context.Add(u);
        _context.SaveChanges();
    }
    public void Update(int id, UsedInfor u) {
        var existing = _context.UsedInfor.Find(id);

        if(existing != null) {
            existing.UserId = u.UserId;
            existing.ComputerId = u.ComputerId;
            existing.UsedTime = u.UsedTime;

            _context.SaveChanges();
        }
    }
    public void Delete(int id) {
        var existing = _context.UsedInfor.Find(id);

        if(existing != null) {
            _context.UsedInfor.Remove(existing);
            _context.SaveChanges();
        }
    }
    public UsedInfor GetById(int id) {
        UsedInfor u = new UsedInfor();

        var existing = _context.UsedInfor.Find(id);

        if(existing != null) {
            u.Id = existing.Id;
            u.UserId = existing.UserId;
            u.ComputerId = existing.ComputerId;
            u.UsedTime = existing.UsedTime;
        }
        return u;
    }
    public List<UsedInfor> GetAll() {
        return _context.UsedInfor.ToList();
    }
}