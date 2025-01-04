namespace Shared;

public static class Testing
{
    private static bool _initialized = false;

    [Before(TestSession)]
    public static void GlobalSetup()
    {
        _initialized = true;
    }

    // [BeforeEvery(Assembly)]
    // public static void GlobalSetup(TestContext testContext)
    // {
    //     _initialized = true;
    // }

    public static bool IsInitialized => _initialized;

    public static void Log() => Console.WriteLine("Starting up...");
}
