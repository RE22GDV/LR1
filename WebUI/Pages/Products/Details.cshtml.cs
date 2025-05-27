using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Products;

public class DetailsModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public DetailsModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public Product? Item { get; private set; }

    public IActionResult OnGet(int id)
    {
        Item = _db.Products.FirstOrDefault(p => p.Id == id);
        return Item is null ? NotFound() : Page();
    }
}