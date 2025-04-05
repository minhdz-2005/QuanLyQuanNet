using Microsoft.EntityFrameworkCore;
using QuanLyQuanNet.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<QLQNContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("QuanLyQuanNet")));

builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<ComputerService>();
builder.Services.AddScoped<LoginInforService>();
builder.Services.AddScoped<UsedInforService>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope()) {
    // var db = scope.ServiceProvider.GetRequiredService<ComputerService>();

    // db.Add(new Computer("hiuh", true, 1.24m));

    // var c = new Computer(5, "Updated", false, 2.11m);
    // db.Update(c);

    // db.Delete(5);

    // Computer c = db.GetById(4);
    // Console.WriteLine(c.Id + c.Name + c.Status + c.Cost);

    // List<Computer> lc = db.GetAll();
    // foreach(var c in lc) {
    //     Console.WriteLine(c.Id + c.Name + c.Status + c.Cost);
    // }

    // var db = scope.ServiceProvider.GetRequiredService<AccountService>();

    // db.Add(new Account(1, 124.33m));

    // db.Update(1, new Account(2, 213.26m));

    // var acc = db.GetById(1);
    // Console.WriteLine(acc.UserId + "   " + acc.Money);

    // List<Account> accs = db.GetAll();
    // foreach(var acc in accs) {
    //     Console.WriteLine(acc.UserId + "   " + acc.Money);
    // }

    // db.Delete(1);
}




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
