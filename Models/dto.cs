namespace MyApp;

public record HrRow(
    int Id,
    string FullName,
    string Title,
    decimal Salary
);

public record ProductRow(
    int Id,
    string Name,
    string Type,
    decimal Price
);

public record OrderRow(
    int Id,
    DateTime OrderDate,
    string Customer,
    string Manager,
    List<string> ProductNames,
    List<string> ServiceNames,
    decimal TotalCost,
    bool Completed);