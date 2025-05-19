// Pages/Orders/Details.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Orders;

public class DetailsModel : PageModel
{
    public Order? Item { get; private set; }

    public IActionResult OnGet(int id)
    {
        Item = DemoDb.Db.Orders.FirstOrDefault(o => o.Id == id);
        return Item is null ? NotFound() : Page();
    }
}
