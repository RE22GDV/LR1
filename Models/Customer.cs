public class Customer
{
    public int Id { get; set; }                 // Код замовника
    public required string FullName { get; set; }
    public required string Address { get; set; }
    public required string Phone { get; set; }

    public override string ToString() => $"{Id,-3} {FullName}";
}