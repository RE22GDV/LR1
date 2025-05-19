// Pages/Queries/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp;
using System.Linq;

namespace WebUI.Pages.Queries;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)] public int? PositionId { get; set; }
    [BindProperty(SupportsGet = true)] public int? ProductTypeId { get; set; }
    [BindProperty(SupportsGet = true)] public int? CustomerId { get; set; }
    [BindProperty(SupportsGet = true)] public DateTime? From { get; set; }
    [BindProperty(SupportsGet = true)] public DateTime? To { get; set; }

    public List<Position> Positions { get; private set; } = [];
    public List<ProductType> ProductTypes { get; private set; } = [];
    public List<Customer> Customers { get; private set; } = [];

    public List<(Employee Emp, Position Pos)> HRDepartment { get; private set; } = [];
    public List<(Product Prod, ProductType Type)> ProductList { get; private set; } = [];
    public List<(Order Ord, Customer Cust, Employee Emp, List<Product> Prods, List<Service> Services)> OrdersInfo { get; private set; } = [];

    public void OnGet()
    {
        var db = DemoDb.Db;

        Positions = db.Positions;
        ProductTypes = db.ProductTypes;
        Customers = db.Customers;

        // Відділ кадрів із фільтром за посадою
        HRDepartment = (from e in db.Employees
                        join p in db.Positions on e.PositionId equals p.Id
                        where PositionId == null || e.PositionId == PositionId
                        select (e, p)).ToList();

        // Список товарів із фільтром за видом
        ProductList = (from p in db.Products
                       join t in db.ProductTypes on p.TypeId equals t.Id
                       where ProductTypeId == null || p.TypeId == ProductTypeId
                       select (p, t)).ToList();

        // Список замовлень із фільтрами
        OrdersInfo = db.Orders
            .Where(o => (CustomerId == null || o.CustomerId == CustomerId)
                     && (From == null || o.OrderDate >= From)
                     && (To == null || o.OrderDate <= To))
            .Select(o => (
                o,
                db.Customers.FirstOrDefault(c => c.Id == o.CustomerId)!,
                db.Employees.FirstOrDefault(e => e.Id == o.EmployeeId)!,
                new[] { o.ProductId1, o.ProductId2, o.ProductId3 }
                    .Where(id => id > 0)
                    .Select(id => db.Products.First(p => p.Id == id)).ToList(),
                new[] { o.ServiceId1, o.ServiceId2, o.ServiceId3 }
                    .Where(id => id > 0)
                    .Select(id => db.Services.First(s => s.Id == id)).ToList()
            )).ToList();
    }
}
