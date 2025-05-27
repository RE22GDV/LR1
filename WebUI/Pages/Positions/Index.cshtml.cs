using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Positions;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<Position> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.Positions.ToList();
    }
}
