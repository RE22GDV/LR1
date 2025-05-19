using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Products;

public class DetailsModel : PageModel
{
    public Product? Item { get; private set; }

    public IActionResult OnGet(int id)
    {
        Item = DemoDb.Db.Products.FirstOrDefault(p => p.Id == id);
        return Item is null ? NotFound() : Page();
    }
}
