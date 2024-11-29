using HotChocolate.Types.Descriptors.Definitions;

#nullable enable

namespace HotChocolate.Configuration;

/// <summary>
/// Represents a callback that is invoked when a type has been completed.
/// </summary>
public delegate void OnInitializeType(
    ITypeDiscoveryContext context,
    DefinitionBase? definition,
    IDictionary<string, object?> contextData);
