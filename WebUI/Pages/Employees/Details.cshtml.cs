using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Employees;

public class DetailsModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public DetailsModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public Employee? Emp { get; private set; }

    public IActionResult OnGet(int id)
    {
        Emp = _db.Employees.FirstOrDefault(x => x.Id == id);
        return Emp is null ? NotFound() : Page();
    }
}