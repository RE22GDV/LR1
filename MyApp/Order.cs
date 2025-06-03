namespace MyApp;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? CompletionDate { get; set; }
    public int CustomerId { get; set; }
    public int ProductId1 { get; set; }
    public int ProductId2 { get; set; }
    public int ProductId3 { get; set; }
    public decimal PrepaymentShare { get; set; }
    public bool Paid { get; set; }
    public bool Completed { get; set; }
    public decimal TotalCost { get; set; }
    public int TotalWarrantyMonths { get; set; }
    public int ServiceId1 { get; set; }
    public int ServiceId2 { get; set; }
    public int ServiceId3 { get; set; }
    public int EmployeeId { get; set; }
}
