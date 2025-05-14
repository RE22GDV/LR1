// TextMenu.cs
namespace MyApp;
using MyApp;
public class TextMenu
{
    private readonly WarehouseSystem _db;
    public TextMenu(WarehouseSystem db) => _db = db;

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("""
            ╔════════════════════════════╗
            ║   М Е Н Ю   С К Л А Д У    ║
            ╠════════════════════════════╣
            ║ 1 – Співробітники          ║
            ║ 2 – Товари                 ║
            ║ 3 – Замовлення             ║
            ║ 0 – Вихід                  ║
            ╚════════════════════════════╝
            """);
            Console.Write("Ваш вибір: ");
            if (!int.TryParse(Console.ReadLine(), out var cmd)) continue;
            switch (cmd)
            {
                case 1: ListAndDetails(_db.Employees);   break;
                case 2: ListAndDetails(_db.Products);    break;
                case 3: ListAndDetails(_db.Orders);      break;
                case 0: return;
                default: Console.WriteLine("Невірний пункт."); break;
            }
        }
    }

    // T повинен мати Id та ToString() для списку і Details() для повного опису
    private static void ListAndDetails<T>(IEnumerable<T> items) where T : class
    {
        Console.Clear();
        foreach (var x in items) Console.WriteLine(x);
        Console.Write("\nID для докладно (Enter – назад): ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out var id)) return;

        // віддзеркаленням викликаємо Details()
        var item = items.FirstOrDefault(i => (int)i!.GetType().GetProperty("Id")!.GetValue(i)! == id);
        if (item is null) { Console.WriteLine("Не знайдено."); return; }
        var details = (string?)item.GetType().GetMethod("Details")?.Invoke(item, null);
        Console.WriteLine("\n" + details);
        Console.WriteLine("\nНатисніть будь-що, щоб повернутися…");
        Console.ReadKey();
        Console.Clear();
    }
}
