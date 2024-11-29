using System.Runtime.CompilerServices;

namespace HotChocolate.PersistedOperations.FileSystem;

internal static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        CookieCrumbleHotChocolate.Initialize();
    }
}
