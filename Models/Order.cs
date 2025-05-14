public class Order
{
    public int Id { get; set; }                         // Для зручності
    public DateTime OrderDate { get; set; }
    public DateTime? CompletionDate { get; set; }
    public int CustomerId { get; set; }

    // До трьох товарів → зберігаємо як масив ідентифікаторів
    public int[] ProductIds { get; set; } = new int[3];

    public decimal PrepaymentShare { get; set; }
    public bool Paid { get; set; }
    public bool Completed { get; set; }
    public decimal TotalCost { get; set; }
    public int TotalWarrantyMonths { get; set; }

    public int[] ServiceIds { get; set; } = new int[3];
    public int EmployeeId { get; set; }

    public override string ToString() =>
        $"{Id,-3} {OrderDate:yyyy-MM-dd} – Клієнт #{CustomerId}, Вартість: {TotalCost:C}";
}
