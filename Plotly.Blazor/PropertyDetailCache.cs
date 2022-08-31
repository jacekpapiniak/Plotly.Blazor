using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Plotly.Blazor;

/// <summary>
/// Caches Property Details for types it has seen before
/// </summary>
public static class PropertyDetailCache
{
    private static readonly Dictionary<Type, PropertyDetail[]> PropertyCache = new ();

    /// <summary>
    /// Returns property details for the given type
    /// </summary>
    /// <param name="type">The type we want property details for</param>
    /// <returns>Property details for type</returns>
    public static IEnumerable<PropertyDetail> GetPropertyDetails(Type type)
    {
        if (!PropertyCache.ContainsKey(type))
        {
            PropertyCache[type] = type.GetProperties().Select(property =>
            {   
                var nameAttributeValue = property.GetCustomAttribute<JsonPropertyNameAttribute>(true)?.Name;
                var containsSubplotAttr = property.GetCustomAttribute(typeof(SubplotAttribute)) != null;
                var containsArrayAttr = property.GetCustomAttribute(typeof(ArrayAttribute)) != null;
                return new PropertyDetail(property, nameAttributeValue, containsSubplotAttr, containsArrayAttr);
            }).ToArray();
        }

        return PropertyCache[type];
    }
}