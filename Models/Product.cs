namespace MyApp;
public class Product
{
    public int Id { get; set; }                 // Код товару
    public int TypeId { get; set; }             // Код виду
    public required string Name { get; set; }
    public required string Brand { get; set; }
    public required string Country { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public required string Specs { get; set; }
    public int WarrantyMonths { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }

    public override string ToString() =>
        $"{Id,-3} {Name,-20} {Price:C}";
}