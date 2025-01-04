namespace Tests;

public class UnitTest1
{
    [Before(TestDiscovery)]
    public static void PreDiscovery()
    {
        // This is needed to force .NET to load the Shared assembly prior to running tests
        // This function could do anything, but it must reference a type from the Shared assembly
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
