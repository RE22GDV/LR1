public class ProductType
{
    public int Id { get; set; }                 // Код виду
    public required string Name { get; set; }
    public required string Description { get; set; }

    public override string ToString() => $"{Id,-3} {Name}";
}