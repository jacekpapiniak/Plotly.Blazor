/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.PolarLib.AngularAxisLib
{
    /// <summary>
    ///     Using <c>strict</c> a numeric string in trace data is not converted to a
    ///     number. Using &#39;convert types&#39; a numeric string in trace data may
    ///     be treated as a number during automatic axis <c>type</c> detection. Defaults
    ///     to layout.autotypenumbers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AutoTypeNumbersEnum
    {
        [EnumMember(Value=@"convert types")]
        ConvertTypes = 0,
        [EnumMember(Value=@"strict")]
        Strict
    }
}