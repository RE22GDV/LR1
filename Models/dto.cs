// Models/Dto.cs (або будь-яка назва)
namespace MyApp;

public record HrRow    (int Id, string FullName, string Title, decimal Salary);
public record ProductRow(int Id, string Type,     string Name,  decimal Price);
public record OrderRow  (int Id, DateTime OrderDate,
                         string Customer, string Manager,
                         decimal TotalCost, bool Completed);
