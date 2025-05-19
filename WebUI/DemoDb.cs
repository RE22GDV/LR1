using MyApp;

namespace WebUI;

public static class DemoDb
{
    public static WarehouseSystem Db { get; } = Init();
    private static WarehouseSystem Init()
    {
        var db = new WarehouseSystem();
        DataSeeder.Seed(db);
        return db;
    }
}
