namespace Tests;

public class UnitTest1
{
    [Before(TestDiscovery)]
    public static void PreDiscovery()
    {
        Shared.Testing.Log();
    }

    [Test]
    public async Task Test1()
    {
        // If the setup hook from the shared library has been successfully called, this test should pass
        var initialized = Shared.Testing.IsInitialized;
        await Assert.That(initialized).IsTrue();
    }
}
