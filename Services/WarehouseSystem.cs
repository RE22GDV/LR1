
// WarehouseSystem.cs
namespace MyApp;    
using System;
using System.Collections.Generic;
using System.Linq;
using MyApp;
 
public class WarehouseSystem
{
    // Колекції «таблиць»
    public List<Position> Positions { get; } = new();
    public List<Employee> Employees { get; } = new();
    public List<ProductType> ProductTypes { get; } = new();
    public List<Product> Products { get; } = new();
    public List<Customer> Customers { get; } = new();
    public List<Service> Services { get; } = new();
    public List<Order> Orders { get; } = new();

    // ----------- «Запити» -----------
    // 1) Відділ кадрів: список співробітників із назвами посад
    public IEnumerable<object> HRDepartment() =>
        from emp in Employees
        join pos in Positions on emp.PositionId equals pos.Id
        select new { emp.Id, emp.FullName, pos.Title, pos.Salary };

    // 2) Список товарів з назвами видів
    public IEnumerable<object> ProductList() =>
        from p in Products
        join t in ProductTypes on p.TypeId equals t.Id
        select new { p.Id, p.Name, Type = t.Name, p.Price };

    // 3) Детальний список замовлень
    public IEnumerable<object> OrderList() =>
        from o in Orders
        join c in Customers on o.CustomerId equals c.Id
        join e in Employees on o.EmployeeId equals e.Id
        select new
        {
            o.Id,
            o.OrderDate,
            Customer = c.FullName,
            Manager = e.FullName,
            o.TotalCost,
            o.Completed
        };
// Services/WarehouseSystem.cs  (додайте всередину класу)
    public T? Get<T>(int id) where T : class
    {
        return typeof(T).Name switch
        {
            nameof(Employee)     => Employees    .FirstOrDefault(e => e.Id == id) as T,
            nameof(Position)     => Positions    .FirstOrDefault(p => p.Id == id) as T,
            nameof(ProductType)  => ProductTypes .FirstOrDefault(p => p.Id == id) as T,
            nameof(Product)      => Products     .FirstOrDefault(p => p.Id == id) as T,
            nameof(Customer)     => Customers    .FirstOrDefault(c => c.Id == id) as T,
            nameof(Service)      => Services     .FirstOrDefault(s => s.Id == id) as T,
            nameof(Order)        => Orders       .FirstOrDefault(o => o.Id == id) as T,
            _ => null
        };
    }

    // ----------- «Фільтри» -----------
    public IEnumerable<Employee> EmployeesByPosition(int positionId) =>
        Employees.Where(e => e.PositionId == positionId);

    public IEnumerable<Product> ProductsByType(int typeId) =>
        Products.Where(p => p.TypeId == typeId);

    public IEnumerable<Order> OrdersByCustomer(int customerId) =>
        Orders.Where(o => o.CustomerId == customerId);

    public IEnumerable<Order> OrdersByDateRange(DateTime from, DateTime to) =>
        Orders.Where(o => o.OrderDate >= from && o.OrderDate <= to);
}
