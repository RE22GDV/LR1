using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Orders;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<Order> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.Orders.ToList();
    }
}
