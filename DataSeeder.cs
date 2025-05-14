// DataSeeder.cs
namespace MyApp;

public static class DataSeeder
{
    public static void Seed(WarehouseSystem db)
    {
        // ===== Посади (5) =====
        db.Positions.AddRange(new[]
        {
            new Position { Id = 1, Title = "Менеджер",
                           Salary = 18_000m,
                           Duties = "Продажі, консультації",
                           Requirements = "Досвід роботи з клієнтами" },

            new Position { Id = 2, Title = "Кладовщик",
                           Salary = 15_000m,
                           Duties = "Прийом-видача товару, інвентаризація",
                           Requirements = "Уважність, базові PC-навички" },

            new Position { Id = 3, Title = "Кур'єр",
                           Salary = 12_000m,
                           Duties = "Доставка замовлень",
                           Requirements = "Водійське посвідчення категорії B" },

            new Position { Id = 4, Title = "Бухгалтер",
                           Salary = 20_000m,
                           Duties = "Облік, звітність",
                           Requirements = "Знання 1С / BAS" },

            new Position { Id = 5, Title = "Сервіс-інженер",
                           Salary = 19_000m,
                           Duties = "Діагностика й ремонт",
                           Requirements = "Навички пайки, роботи з вимірювальними приладами" }
        });

        // ===== Співробітники (2 з 10) =====
        db.Employees.AddRange(new[]
        {
            new Employee
            {
                Id = 1,
                FullName = "Іван Петренко",
                Age = 30,
                Gender = "M",
                Address = "м. Київ",
                Phone = "050-111-22-33",
                PassportInfo = "АА123456",
                PositionId = 1
            },
            new Employee
            {
                Id = 2,
                FullName = "Олена Сидоренко",
                Age = 27,
                Gender = "F",
                Address = "м. Львів",
                Phone = "067-222-33-44",
                PassportInfo = "BB987654",
                PositionId = 2
            }
        });

        // ===== Види товарів (2 з 15) =====
        db.ProductTypes.AddRange(new[]
        {
            new ProductType { Id = 1, Name = "Материнська плата", Description = "ATX / mATX" },
            new ProductType { Id = 2, Name = "Процесор",          Description = "Intel / AMD" }
        });

        // ===== Товари (2 з 15) =====
        db.Products.AddRange(new[]
        {
            new Product
            {
                Id = 1, TypeId = 1, Name = "ASUS TUF B650",
                Brand = "ASUS", Country = "Taiwan",
                ManufacturingDate = new DateTime(2024, 2, 1),
                Specs = "AM5, DDR5-5600", WarrantyMonths = 36,
                Description = "Плата для Ryzen 7000",
                Price = 8_900m
            },
            new Product
            {
                Id = 2, TypeId = 2, Name = "Ryzen 7 7800X3D",
                Brand = "AMD", Country = "Malaysia",
                ManufacturingDate = new DateTime(2024, 3, 10),
                Specs = "8C/16T, 4.2 GHz", WarrantyMonths = 36,
                Description = "Ігровий ЦП з 3D V-Cache",
                Price = 15_400m
            }
        });

        // ===== Замовники (2 з 10) =====
        db.Customers.AddRange(new[]
        {
            new Customer { Id = 1, FullName = "ТОВ «Геймер»", Address = "Одеса", Phone = "048-555-66-77" },
            new Customer { Id = 2, FullName = "ПП «Комп-Сервіс»", Address = "Дніпро", Phone = "056-777-88-99" }
        });

        // ===== Послуги (2 з 5) =====
        db.Services.AddRange(new[]
        {
            new Service { Id = 1, Name = "Збірка ПК",   Description = "Комплексна збірка",  Cost = 1_500m },
            new Service { Id = 2, Name = "Тестування",  Description = "Стрес-тест 24 год",  Cost = 800m  }
        });

        // ===== Замовлення (1 з 10) =====
        db.Orders.Add(new Order
        {
            Id = 1,
            OrderDate = new DateTime(2025, 5, 10),
            CustomerId = 1,
            ProductIds = new[] { 1, 2, 0 },
            PrepaymentShare = 0.5m,
            Paid = true,
            Completed = false,
            TotalCost = 8_900m + 15_400m + 1_500m,
            TotalWarrantyMonths = 36,
            ServiceIds = new[] { 1, 0, 0 },
            EmployeeId = 1
        });
    }
}
