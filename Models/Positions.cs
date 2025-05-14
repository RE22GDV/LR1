namespace MyApp;
public class Position
{
    public int Id { get; set; }                 // Код посади
    public required string Title { get; set; }           // Найменування
    public required decimal Salary { get; set; }         // Оклад
    public required string Duties { get; set; }          // Обов’язки
    public required string Requirements { get; set; }    // Вимоги

    public override string ToString() =>
        $"{Id,-3} {Title,-15} Оклад: {Salary:C}";
}