using Microsoft.EntityFrameworkCore;
using MyApp;

var builder = WebApplication.CreateBuilder(args);

// Підключення до SQLite
builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseSqlite("Data Source=warehouse.db"));

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

// === ДОДАЄМО ЦЕ: ініціалізація БД ===
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<WarehouseDbContext>();
    
    // Створити базу, якщо її ще нема
    db.Database.Migrate();

    // Засіяти даними, якщо таблиці порожні
    //if (!db.Employees.Any())
    //{
    //    DataSeeder.Seed(db);
    //    db.SaveChanges();
    //}
}

app.Run();