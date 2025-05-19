using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;

namespace WebUI.Pages.Employees;

public class IndexModel : PageModel
{
    public List<Employee> Data { get; private set; } = [];

    public void OnGet()
    {
        Data = DemoDb.Db.Employees;
    }
}
