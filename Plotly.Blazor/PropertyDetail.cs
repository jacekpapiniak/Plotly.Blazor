using System.Reflection;

namespace Plotly.Blazor;

/// <summary>
/// Detail about a property
/// </summary>
/// <param name="Property">The property info for a property</param>
/// <param name="NameAttributeValue">The value of name attribute associated with the property</param>
/// <param name="ContainsSubPlot">Does the property contains a sub plot</param>
/// <param name="ContainsArray">Does the property contain an array</param>
public record PropertyDetail(PropertyInfo Property, string NameAttributeValue, bool ContainsSubPlot, bool ContainsArray);