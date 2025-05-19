// Pages/ProductTypes/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.ProductTypes;

public class IndexModel : PageModel
{
    public List<ProductType> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.ProductTypes;
    }
}
