namespace Shared;

public static class Testing
{
    private static bool _initialized = false;

    [Before(Assembly)]
    public static void GlobalSetup()
    {
        _initialized = true;
    }

    public static bool IsInitialized => _initialized;

    public static void Log() => Console.WriteLine("Starting up...");
}
