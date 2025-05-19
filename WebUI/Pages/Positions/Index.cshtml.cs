// Pages/Positions/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Positions;

public class IndexModel : PageModel
{
    public List<Position> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Positions;
    }
}
