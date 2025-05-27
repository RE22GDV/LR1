// Pages/Customers/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Customers;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<Customer> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.Customers.ToList();
    }
}