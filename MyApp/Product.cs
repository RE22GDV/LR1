namespace MyApp;

public class Product
{
    public int Id { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime ManufacturingDate { get; set; }
    public string Specs { get; set; } = string.Empty;
    public int WarrantyMonths { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
