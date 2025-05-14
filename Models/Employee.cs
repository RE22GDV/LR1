// Models/Employee.cs
namespace MyApp;

/// <summary>
/// Працівник складу-магазину.
/// </summary>
public class Employee
{
    // ───── Ключове поле ─────
    public int Id { get; set; }

    // ───── Особисті дані ─────
    public string FullName     { get; set; } = string.Empty;
    public int    Age          { get; set; }
    public string Gender       { get; set; } = string.Empty;
    public string Address      { get; set; } = string.Empty;
    public string Phone        { get; set; } = string.Empty;
    public string PassportInfo { get; set; } = string.Empty;

    // ───── Посада ─────
    public int PositionId { get; set; }    // зв’язок із таблицею Position

    // ────────────────────────────────
    //          С Л У Ж Б О В І
    // ────────────────────────────────

    /// <summary>Коротка форма для списків (override ToString).</summary>
    public override string ToString() =>
        $"{Id,-3} {FullName,-25} {Age,2} роки, Посада №{PositionId}";

    /// <summary>Повний багаторядковий опис для меню Details().</summary>
    public string Details() => $"""
        ── Співробітник #{Id} ───────────────
        ПІБ:            {FullName}
        Вік:            {Age}
        Стать:          {Gender}
        Телефон:        {Phone}
        Адреса:         {Address}
        Паспорт:        {PassportInfo}
        Код посади:     {PositionId}
        """;
}
