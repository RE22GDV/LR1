// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;
using System.Linq;

namespace WebUI.Pages;

public class IndexModel : PageModel
{
    public int EmpCount         { get; private set; }
    public int ProductCount     { get; private set; }
    public int OrderCount       { get; private set; }
    public int PositionCount    { get; private set; }
    public int ProductTypeCount { get; private set; }
    public int CustomerCount    { get; private set; }
    public int ServiceCount     { get; private set; }

    // Запит "Відділ кадрів": поєднує співробітників і їхні посади
    public List<(Employee Emp, Position Pos)> HRDepartment { get; private set; } = [];

    public void OnGet()
    {
        var db = DemoDb.Db;

        EmpCount         = db.Employees.Count;
        ProductCount     = db.Products.Count;
        OrderCount       = db.Orders.Count;
        PositionCount    = db.Positions.Count;
        ProductTypeCount = db.ProductTypes.Count;
        CustomerCount    = db.Customers.Count;
        ServiceCount     = db.Services.Count;

        HRDepartment = (from e in db.Employees
                        join p in db.Positions on e.PositionId equals p.Id
                        select (e, p)).ToList();
    }
}
