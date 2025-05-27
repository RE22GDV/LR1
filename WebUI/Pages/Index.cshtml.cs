using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.Pages;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    public int EmpCount         { get; private set; }
    public int ProductCount     { get; private set; }
    public int OrderCount       { get; private set; }
    public int PositionCount    { get; private set; }
    public int ProductTypeCount { get; private set; }
    public int CustomerCount    { get; private set; }
    public int ServiceCount     { get; private set; }

    public List<HrRow> HRDepartment { get; private set; } = [];

    public void OnGet()
    {
        EmpCount         = _db.Employees.Count();
        ProductCount     = _db.Products.Count();
        OrderCount       = _db.Orders.Count();
        PositionCount    = _db.Positions.Count();
        ProductTypeCount = _db.ProductTypes.Count();
        CustomerCount    = _db.Customers.Count();
        ServiceCount     = _db.Services.Count();

        HRDepartment = (from e in _db.Employees
                        join p in _db.Positions on e.PositionId equals p.Id
                        select new HrRow(
                            e.Id,
                            e.FullName,
                            p.Title,
                            p.Salary
                        )).ToList();
    }
}