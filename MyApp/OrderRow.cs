namespace MyApp;

public record OrderRow(int Id,
                        DateTime OrderDate,
                        string CustomerName,
                        string EmployeeName,
                        List<string> ProductNames,
                        List<string> ServiceNames,
                        decimal TotalCost,
                        bool Completed);
