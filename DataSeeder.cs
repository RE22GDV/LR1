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

        // ===== Співробітники (10 з 10) =====
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
            },
            new Employee
            {
                Id = 3,
                FullName = "Максим Коваль",
                Age = 35,
                Gender = "M",
                Address = "м. Харків",
                Phone = "093-333-44-55",
                PassportInfo = "СЕ654321",
                PositionId = 3
            },
            new Employee
            {
                Id = 4,
                FullName = "Наталія Іванова",
                Age = 29,
                Gender = "F",
                Address = "м. Полтава",
                Phone = "050-555-66-77",
                PassportInfo = "КК777888",
                PositionId = 4
            },
            new Employee
            {
                Id = 5,
                FullName = "Артем Шевченко",
                Age = 32,
                Gender = "M",
                Address = "м. Дніпро",
                Phone = "067-888-99-00",
                PassportInfo = "ММ987321",
                PositionId = 5
            },
            new Employee
            {
                Id = 6,
                FullName = "Ірина Литвин",
                Age = 26,
                Gender = "F",
                Address = "м. Черкаси",
                Phone = "093-123-45-67",
                PassportInfo = "ХХ456789",
                PositionId = 1
            },
            new Employee
            {
                Id = 7,
                FullName = "Олександр Бондар",
                Age = 41,
                Gender = "M",
                Address = "м. Вінниця",
                Phone = "050-234-56-78",
                PassportInfo = "YY765432",
                PositionId = 2
            },
            new Employee
            {
                Id = 8,
                FullName = "Лідія Кравченко",
                Age = 24,
                Gender = "F",
                Address = "м. Чернівці",
                Phone = "097-345-67-89",
                PassportInfo = "ZZ112233",
                PositionId = 3
            },
            new Employee
            {
                Id = 9,
                FullName = "Денис Марченко",
                Age = 31,
                Gender = "M",
                Address = "м. Хмельницький",
                Phone = "096-456-78-90",
                PassportInfo = "ЛЛ334455",
                PositionId = 4
            },
            new Employee
            {
                Id = 10,
                FullName = "Тетяна Вербицька",
                Age = 28,
                Gender = "F",
                Address = "м. Житомир",
                Phone = "099-567-89-01",
                PassportInfo = "РР998877",
                PositionId = 5
            }
        });

        // ===== Види товарів (15 з 15) =====
        db.ProductTypes.AddRange(new[]
        {
            new ProductType { Id = 1, Name = "Материнська плата", Description = "ATX / mATX" },
            new ProductType { Id = 2, Name = "Процесор",          Description = "Intel / AMD" },
            new ProductType { Id = 3, Name = "Оперативна пам’ять", Description = "DDR4 / DDR5" },
            new ProductType { Id = 4, Name = "Відеокарта",         Description = "NVIDIA / AMD GPU" },
            new ProductType { Id = 5, Name = "SSD",                Description = "SATA / NVMe накопичувачі" },
            new ProductType { Id = 6, Name = "HDD",                Description = "Жорсткі диски 2.5'' / 3.5''" },
            new ProductType { Id = 7, Name = "Блок живлення",      Description = "ATX, 80+ Bronze/Gold" },
            new ProductType { Id = 8, Name = "Корпус",             Description = "Mini Tower / Mid Tower" },
            new ProductType { Id = 9, Name = "Кулер для процесора", Description = "Повітряні / водяні системи" },
            new ProductType { Id = 10, Name = "Монітор",           Description = "Full HD / 2K / 4K, IPS / VA" },
            new ProductType { Id = 11, Name = "Клавіатура",        Description = "Мембранні / механічні" },
            new ProductType { Id = 12, Name = "Миша",              Description = "Провідні / безпровідні" },
            new ProductType { Id = 13, Name = "Навушники",         Description = "З мікрофоном / без, 3.5мм / USB" },
            new ProductType { Id = 14, Name = "Мережева карта",    Description = "LAN / Wi-Fi адаптери" },
            new ProductType { Id = 15, Name = "Контролер вентиляторів", Description = "Регулятори швидкості обертання" }
        });

        // ===== Товари (15 з 15) =====
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
        },
        new Product
        {
            Id = 3, TypeId = 3, Name = "Kingston Fury 16GB",
            Brand = "Kingston", Country = "USA",
            ManufacturingDate = new DateTime(2023, 12, 5),
            Specs = "DDR5-6000", WarrantyMonths = 60,
            Description = "ОЗП для геймінгу",
            Price = 2_200m
        },
        new Product
        {
            Id = 4, TypeId = 4, Name = "NVIDIA RTX 4070",
            Brand = "NVIDIA", Country = "China",
            ManufacturingDate = new DateTime(2024, 1, 15),
            Specs = "12GB GDDR6X", WarrantyMonths = 36,
            Description = "Графічна карта для ігор",
            Price = 28_000m
        },
        new Product
        {
            Id = 5, TypeId = 5, Name = "Samsung 980 PRO 1TB",
            Brand = "Samsung", Country = "Korea",
            ManufacturingDate = new DateTime(2023, 10, 30),
            Specs = "NVMe, PCIe 4.0", WarrantyMonths = 60,
            Description = "Швидкий SSD-диск",
            Price = 4_500m
        },
        new Product
        {
            Id = 6, TypeId = 6, Name = "WD Blue 2TB",
            Brand = "Western Digital", Country = "Thailand",
            ManufacturingDate = new DateTime(2023, 9, 18),
            Specs = "5400 RPM, SATA", WarrantyMonths = 24,
            Description = "Жорсткий диск для архівації",
            Price = 2_700m
        },
        new Product
        {
            Id = 7, TypeId = 7, Name = "Chieftec 650W 80+ Bronze",
            Brand = "Chieftec", Country = "Germany",
            ManufacturingDate = new DateTime(2023, 8, 5),
            Specs = "ATX, активний PFC", WarrantyMonths = 36,
            Description = "Надійне живлення для ПК",
            Price = 2_200m
        },
        new Product
        {
            Id = 8, TypeId = 8, Name = "Deepcool MATREXX 55",
            Brand = "Deepcool", Country = "China",
            ManufacturingDate = new DateTime(2024, 1, 25),
            Specs = "ATX, скло", WarrantyMonths = 24,
            Description = "Корпус із підсвіткою",
            Price = 1_800m
        },
        new Product
        {
            Id = 9, TypeId = 9, Name = "be quiet! Pure Rock 2",
            Brand = "be quiet!", Country = "Germany",
            ManufacturingDate = new DateTime(2023, 11, 2),
            Specs = "120 мм, тихий", WarrantyMonths = 36,
            Description = "Кулер для процесора",
            Price = 1_300m
        },
        new Product
        {
            Id = 10, TypeId = 10, Name = "Dell UltraSharp 27\"",
            Brand = "Dell", Country = "USA",
            ManufacturingDate = new DateTime(2024, 4, 1),
            Specs = "2K, IPS, 75Hz", WarrantyMonths = 36,
            Description = "Професійний монітор",
            Price = 9_900m
        },
        new Product
        {
            Id = 11, TypeId = 11, Name = "Logitech G213 Prodigy",
            Brand = "Logitech", Country = "China",
            ManufacturingDate = new DateTime(2023, 10, 12),
            Specs = "RGB, мембранна", WarrantyMonths = 24,
            Description = "Геймерська клавіатура",
            Price = 1_800m
        },
        new Product
        {
            Id = 12, TypeId = 12, Name = "Razer DeathAdder V2",
            Brand = "Razer", Country = "China",
            ManufacturingDate = new DateTime(2023, 11, 28),
            Specs = "20K DPI, USB", WarrantyMonths = 24,
            Description = "Ігрова миша",
            Price = 1_700m
        },
        new Product
        {
            Id = 13, TypeId = 13, Name = "HyperX Cloud II",
            Brand = "HyperX", Country = "USA",
            ManufacturingDate = new DateTime(2023, 7, 7),
            Specs = "USB / 3.5mm, з мікрофоном", WarrantyMonths = 24,
            Description = "Ігрові навушники",
            Price = 3_200m
        },
        new Product
        {
            Id = 14, TypeId = 14, Name = "TP-Link Archer T4U",
            Brand = "TP-Link", Country = "China",
            ManufacturingDate = new DateTime(2024, 2, 10),
            Specs = "Wi-Fi 5, USB 3.0", WarrantyMonths = 12,
            Description = "Зовнішній Wi-Fi адаптер",
            Price = 900m
        },
        new Product
        {
            Id = 15, TypeId = 15, Name = "NZXT Grid+ V3",
            Brand = "NZXT", Country = "USA",
            ManufacturingDate = new DateTime(2023, 12, 20),
            Specs = "6 каналів, USB", WarrantyMonths = 12,
            Description = "Контролер вентиляторів",
            Price = 1_100m
        }
    });


        // ===== Замовники (10 з 10) =====
        db.Customers.AddRange(new[]
        {
            new Customer { Id = 1, FullName = "ТОВ «Геймер»", Address = "Одеса", Phone = "048-555-66-77" },
            new Customer { Id = 2, FullName = "ПП «Комп-Сервіс»", Address = "Дніпро", Phone = "056-777-88-99" },
            new Customer { Id = 3, FullName = "ТОВ «Цифра+»", Address = "Київ", Phone = "044-333-22-11" },
            new Customer { Id = 4, FullName = "ФОП Іванов С.М.", Address = "Львів", Phone = "032-777-11-22" },
            new Customer { Id = 5, FullName = "ПП «БайтЛаб»", Address = "Харків", Phone = "057-888-99-00" },
            new Customer { Id = 6, FullName = "ТОВ «Розумні рішення»", Address = "Запоріжжя", Phone = "061-456-78-90" },
            new Customer { Id = 7, FullName = "ФОП Коваленко І.І.", Address = "Полтава", Phone = "0532-321-123" },
            new Customer { Id = 8, FullName = "ТОВ «СмартСистеми»", Address = "Івано-Франківськ", Phone = "0342-456-456" },
            new Customer { Id = 9, FullName = "ПП «ДіджиталТех»", Address = "Черкаси", Phone = "0472-123-987" },
            new Customer { Id = 10, FullName = "ФОП Савчук Т.П.", Address = "Рівне", Phone = "0362-555-121" },
            new Customer { Id = 11, FullName = "ТОВ «ТехноСвіт»", Address = "Кривий Ріг", Phone = "0564-654-321" },
            new Customer { Id = 12, FullName = "ПП «Компік»", Address = "Хмельницький", Phone = "0382-112-233" },
            new Customer { Id = 13, FullName = "ФОП Андрійчук В.В.", Address = "Чернівці", Phone = "0372-765-456" },
            new Customer { Id = 14, FullName = "ТОВ «ІТ-Сервіс»", Address = "Тернопіль", Phone = "0352-321-456" },
            new Customer { Id = 15, FullName = "ФОП Пономаренко Д.Д.", Address = "Житомир", Phone = "0412-789-321" }
        });

        // ===== Послуги (2 з 5) =====
        db.Services.AddRange(new[]
        {
            new Service { Id = 1, Name = "Збірка ПК", Description = "Комплексна збірка системного блоку", Cost = 1500m },
            new Service { Id = 2, Name = "Тестування", Description = "Стрес-тестування протягом 24 годин", Cost = 800m },
            new Service { Id = 3, Name = "Установка ОС", Description = "Інсталяція Windows/Linux з налаштуванням", Cost = 500m },
            new Service { Id = 4, Name = "Чистка ПК", Description = "Фізична чистка та заміна термопасти", Cost = 600m },
            new Service { Id = 5, Name = "Діагностика", Description = "Повна перевірка працездатності", Cost = 300m }
        });

        // ===== Замовлення (1 з 10) =====
        db.Orders.AddRange(new[]
        {
            new Order { Id = 1, OrderDate = new DateTime(2025, 5, 10), CompletionDate = null, CustomerId = 1,
                ProductId1 = 1, ProductId2 = 2, ProductId3 = 0,
                ServiceId1 = 1, ServiceId2 = 0, ServiceId3 = 0,
                PrepaymentShare = 0.5m, Paid = true, Completed = false,
                TotalCost = 8900 + 15400 + 1500, TotalWarrantyMonths = 36, EmployeeId = 1 },

            new Order { Id = 2, OrderDate = new DateTime(2025, 4, 18), CompletionDate = new DateTime(2025, 4, 20), CustomerId = 2,
                ProductId1 = 3, ProductId2 = 0, ProductId3 = 0,
                ServiceId1 = 2, ServiceId2 = 3, ServiceId3 = 0,
                PrepaymentShare = 0.7m, Paid = true, Completed = true,
                TotalCost = 12000 + 800 + 500, TotalWarrantyMonths = 24, EmployeeId = 2 },

            new Order { Id = 3, OrderDate = new DateTime(2025, 3, 15), CompletionDate = new DateTime(2025, 3, 16), CustomerId = 3,
                ProductId1 = 4, ProductId2 = 5, ProductId3 = 6,
                ServiceId1 = 1, ServiceId2 = 5, ServiceId3 = 0,
                PrepaymentShare = 0.4m, Paid = true, Completed = true,
                TotalCost = 11000 + 10400 + 9600 + 1500 + 300, TotalWarrantyMonths = 36, EmployeeId = 3 },

            new Order { Id = 4, OrderDate = new DateTime(2025, 5, 1), CompletionDate = null, CustomerId = 4,
                ProductId1 = 7, ProductId2 = 8, ProductId3 = 0,
                ServiceId1 = 3, ServiceId2 = 0, ServiceId3 = 0,
                PrepaymentShare = 0.6m, Paid = false, Completed = false,
                TotalCost = 8700 + 8300 + 500, TotalWarrantyMonths = 24, EmployeeId = 4 },

            new Order { Id = 5, OrderDate = new DateTime(2025, 5, 3), CompletionDate = new DateTime(2025, 5, 6), CustomerId = 5,
                ProductId1 = 9, ProductId2 = 10, ProductId3 = 11,
                ServiceId1 = 4, ServiceId2 = 0, ServiceId3 = 0,
                PrepaymentShare = 0.3m, Paid = true, Completed = true,
                TotalCost = 6000 + 9900 + 7300 + 600, TotalWarrantyMonths = 18, EmployeeId = 5 },

            new Order { Id = 6, OrderDate = new DateTime(2025, 2, 25), CompletionDate = new DateTime(2025, 2, 26), CustomerId = 6,
                ProductId1 = 12, ProductId2 = 0, ProductId3 = 0,
                ServiceId1 = 2, ServiceId2 = 0, ServiceId3 = 0,
                PrepaymentShare = 0.9m, Paid = true, Completed = true,
                TotalCost = 6200 + 800, TotalWarrantyMonths = 12, EmployeeId = 6 },

            new Order { Id = 7, OrderDate = new DateTime(2025, 4, 12), CompletionDate = null, CustomerId = 7,
                ProductId1 = 13, ProductId2 = 14, ProductId3 = 15,
                ServiceId1 = 5, ServiceId2 = 1, ServiceId3 = 0,
                PrepaymentShare = 0.8m, Paid = false, Completed = false,
                TotalCost = 9900 + 10200 + 10800 + 300 + 1500, TotalWarrantyMonths = 36, EmployeeId = 7 },

            new Order { Id = 8, OrderDate = new DateTime(2025, 5, 12), CompletionDate = null, CustomerId = 8,
                ProductId1 = 5, ProductId2 = 6, ProductId3 = 0,
                ServiceId1 = 1, ServiceId2 = 4, ServiceId3 = 0,
                PrepaymentShare = 0.5m, Paid = true, Completed = false,
                TotalCost = 10400 + 9600 + 1500 + 600, TotalWarrantyMonths = 30, EmployeeId = 8 },

            new Order { Id = 9, OrderDate = new DateTime(2025, 1, 10), CompletionDate = new DateTime(2025, 1, 12), CustomerId = 9,
                ProductId1 = 3, ProductId2 = 4, ProductId3 = 0,
                ServiceId1 = 2, ServiceId2 = 3, ServiceId3 = 5,
                PrepaymentShare = 0.75m, Paid = true, Completed = true,
                TotalCost = 12000 + 11000 + 800 + 500 + 300, TotalWarrantyMonths = 24, EmployeeId = 9 },

            new Order { Id = 10, OrderDate = new DateTime(2025, 5, 18), CompletionDate = null, CustomerId = 10,
                ProductId1 = 2, ProductId2 = 12, ProductId3 = 0,
                ServiceId1 = 1, ServiceId2 = 2, ServiceId3 = 3,
                PrepaymentShare = 0.6m, Paid = false, Completed = false,
                TotalCost = 15400 + 6200 + 1500 + 800 + 500, TotalWarrantyMonths = 36, EmployeeId = 10 }
        });

    }
}
