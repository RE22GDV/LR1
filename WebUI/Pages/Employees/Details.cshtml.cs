using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;
using WebUI;

namespace WebUI.Pages.Employees;

public class DetailsModel : PageModel
{
    public Employee? Emp { get; private set; }

    public IActionResult OnGet(int id)
    {
        Emp = DemoDb.Db.Employees.FirstOrDefault(x => x.Id == id);
        return Emp is null ? NotFound() : Page();
    }
}
