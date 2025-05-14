public class Service
{
    public int Id { get; set; }                 // Код послуги
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Cost { get; set; }

    public override string ToString() => $"{Id,-3} {Name} ({Cost:C})";
}