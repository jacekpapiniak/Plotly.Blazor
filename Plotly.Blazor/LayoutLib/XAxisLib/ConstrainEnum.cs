/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     If this axis needs to be compressed (either due to its own <c>scaleanchor</c>
    ///     and <c>scaleratio</c> or those of the other axis), determines how that happens:
    ///     by increasing the <c>range</c>, or by decreasing the <c>domain</c>. Default
    ///     is <c>domain</c> for axes containing image traces, <c>range</c> otherwise.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ConstrainEnum
    {
        [EnumMember(Value=@"range")]
        Range,
        [EnumMember(Value=@"domain")]
        Domain
    }
}