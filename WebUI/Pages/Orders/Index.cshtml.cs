// Pages/Orders/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Orders;

public class IndexModel : PageModel
{
    public List<Order> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Orders;
    }
}
