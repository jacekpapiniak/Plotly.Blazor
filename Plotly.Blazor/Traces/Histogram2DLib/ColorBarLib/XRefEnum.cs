/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Histogram2DLib.ColorBarLib
{
    /// <summary>
    ///     Sets the container <c>x</c> refers to. <c>container</c> spans the entire
    ///     <c>width</c> of the plot. <c>paper</c> refers to the width of the plotting
    ///     area only.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XRefEnum
    {
        [EnumMember(Value=@"paper")]
        Paper = 0,
        [EnumMember(Value=@"container")]
        Container
    }
}