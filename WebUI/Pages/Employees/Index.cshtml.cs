using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Products;

public class IndexModel : PageModel
{
    public List<Product> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Products;
    }
}
