public class Order
{
    public int Id { get; set; }                        // ID замовлення (для зручності)
    public DateTime OrderDate { get; set; }            // Дата замовлення
    public DateTime? CompletionDate { get; set; }      // Дата виконання (може бути null)

    public int CustomerId { get; set; }                // Код замовника

    public int ProductId1 { get; set; }                // Код комплектуючого 1
    public int ProductId2 { get; set; }                // Код комплектуючого 2
    public int ProductId3 { get; set; }                // Код комплектуючого 3

    public decimal PrepaymentShare { get; set; }       // Частка передоплати
    public bool Paid { get; set; }                     // Відмітка про оплату
    public bool Completed { get; set; }                // Відмітка про виконання

    public decimal TotalCost { get; set; }             // Загальна вартість
    public int TotalWarrantyMonths { get; set; }       // Термін загальної гарантії

    public int ServiceId1 { get; set; }                // Код ПОСЛУГИ 1
    public int ServiceId2 { get; set; }                // Код ПОСЛУГИ 2
    public int ServiceId3 { get; set; }                // Код ПОСЛУГИ 3

    public int EmployeeId { get; set; }                // Код співробітника

    public override string ToString() =>
        $"{Id,-3} {OrderDate:yyyy-MM-dd} – Клієнт #{CustomerId}, Вартість: {TotalCost:C}";
}