using System.Runtime.CompilerServices;

namespace HotChocolate.PersistedOperations.Redis;

internal static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        CookieCrumbleHotChocolate.Initialize();
    }
}
