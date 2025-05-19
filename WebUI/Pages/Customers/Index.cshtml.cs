// Pages/Customers/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Customers;

public class IndexModel : PageModel
{
    public List<Customer> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Customers;
    }
}
