using System.Windows.Markup;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanNet.Models;

public class ComputerService {
    private readonly QLQNContext _context;
    public ComputerService (QLQNContext context) {
        _context = context;
    }
    public void Add (Computer c) {
        _context.Computer.Add(c);
        _context.SaveChanges();
    }
    public void Update (int id, Computer c) {
        var existing = _context.Computer.Find(id);
        if(existing != null) {
            existing.Name = c.Name;
            existing.Cost = c.Cost;
            existing.Status = c.Status;

            _context.SaveChanges();
        }
    }
    public void Delete (int id) {
        var c = _context.Computer.Find (id);
        if (c != null) {
            _context.Computer.Remove(c);
            _context.SaveChanges();
        }
    }
    public Computer GetById(int id) {
        Computer c = new Computer();
        var existing = _context.Computer.Find(id);
        if(existing != null) {
            c.Id = existing.Id;
            c.Name = existing.Name;
            c.Status = existing.Status;
            c.Cost = existing.Cost;
        }
        return c;
    }
    public List<Computer> GetAll() {
        return _context.Computer.ToList();
    }
}