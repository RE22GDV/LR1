// Pages/Services/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Services;

public class IndexModel : PageModel
{
    public List<Service> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Services;
    }
}
