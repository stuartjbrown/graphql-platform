using System.Runtime.CompilerServices;

namespace HotChocolate.Data.Sorting;

internal static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        CookieCrumbleHotChocolate.Initialize();
    }
}
