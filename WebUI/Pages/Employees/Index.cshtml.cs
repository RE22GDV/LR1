using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Employees;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<Employee> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.Employees.ToList();
    }
}