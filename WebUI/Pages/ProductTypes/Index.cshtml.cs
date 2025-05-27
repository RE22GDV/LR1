using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.ProductTypes;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<ProductType> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.ProductTypes.ToList();
    }
}