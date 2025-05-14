// Program.cs
using System.Globalization;
using MyApp;

CultureInfo.DefaultThreadCurrentCulture = new("uk-UA");

var db = new WarehouseSystem();
DataSeeder.Seed(db);      // або Persistence.Load(db)

new TextMenu(db).Show();
