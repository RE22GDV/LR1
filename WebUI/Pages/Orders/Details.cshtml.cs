using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Orders;

public class DetailsModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public DetailsModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public Order? Item { get; private set; }

    public IActionResult OnGet(int id)
    {
        Item = _db.Orders.FirstOrDefault(o => o.Id == id);
        return Item is null ? NotFound() : Page();
    }
}
