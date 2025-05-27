using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.Pages.Services;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public List<Service> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = _db.Services.ToList();
    }
}