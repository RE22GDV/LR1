using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp;

namespace WebUI.Pages.Queries;

public class IndexModel : PageModel
{
    private readonly WarehouseDbContext _db;

    public IndexModel(WarehouseDbContext db)
    {
        _db = db;
    }

    [BindProperty(SupportsGet = true)] public int? PositionId { get; set; }
    [BindProperty(SupportsGet = true)] public int? ProductTypeId { get; set; }
    [BindProperty(SupportsGet = true)] public int? CustomerId { get; set; }
    [BindProperty(SupportsGet = true)] public DateTime? From { get; set; }
    [BindProperty(SupportsGet = true)] public DateTime? To { get; set; }

    public List<Position> Positions { get; private set; } = [];
    public List<ProductType> ProductTypes { get; private set; } = [];
    public List<Customer> Customers { get; private set; } = [];

    public List<HrRow> HRDepartment { get; private set; } = [];
    public List<ProductRow> ProductList { get; private set; } = [];
    public List<OrderRow> OrdersInfo { get; private set; } = [];

    public void OnGet()
    {
        Positions = _db.Positions.ToList();
        ProductTypes = _db.ProductTypes.ToList();
        Customers = _db.Customers.ToList();

        // DTO для Відділу кадрів
        HRDepartment = (from e in _db.Employees
                        join p in _db.Positions on e.PositionId equals p.Id
                        where PositionId == null || e.PositionId == PositionId
                        select new HrRow(
                            e.Id,
                            e.FullName,
                            p.Title,
                            p.Salary
                        )).ToList();

        // DTO для Товарів
        ProductList = (from p in _db.Products
                       join t in _db.ProductTypes on p.TypeId equals t.Id
                       where ProductTypeId == null || p.TypeId == ProductTypeId
                       select new ProductRow(
                           p.Id,
                           t.Name,
                           p.Name,
                           p.Price
                       )).ToList();

        // DTO для Замовлень
        OrdersInfo = _db.Orders
            .Where(o => (CustomerId == null || o.CustomerId == CustomerId)
                     && (From == null || o.OrderDate >= From)
                     && (To == null || o.OrderDate <= To))
            .AsEnumerable() // переключаємося на LINQ-to-Objects
            .Select(o =>
            {
                var customerName = _db.Customers.First(c => c.Id == o.CustomerId).FullName;
                var employeeName = _db.Employees.First(e => e.Id == o.EmployeeId).FullName;

                var productNames = new[] { o.ProductId1, o.ProductId2, o.ProductId3 }
                    .Where(id => id > 0)
                    .Select(id => _db.Products.First(p => p.Id == id).Name)
                    .ToList();

                var serviceNames = new[] { o.ServiceId1, o.ServiceId2, o.ServiceId3 }
                    .Where(id => id > 0)
                    .Select(id => _db.Services.First(s => s.Id == id).Name)
                    .ToList();

                return new OrderRow(
                    o.Id,
                    o.OrderDate,
                    customerName,
                    employeeName,
                    productNames,
                    serviceNames,
                    o.TotalCost,
                    o.Completed
                );
            }).ToList();
    }
}