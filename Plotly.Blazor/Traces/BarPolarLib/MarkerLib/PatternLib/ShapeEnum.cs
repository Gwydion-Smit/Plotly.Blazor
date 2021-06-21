/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.BarPolarLib.MarkerLib.PatternLib
{
    /// <summary>
    ///     Sets the shape of the pattern fill. By default, no pattern is used for filling
    ///     the area.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"")]
        Empty = 0,
        [EnumMember(Value=@"/")]
        Slash,
        [EnumMember(Value=@"\")]
        Backslash,
        [EnumMember(Value=@"x")]
        X,
        [EnumMember(Value=@"-")]
        Minus,
        [EnumMember(Value=@"|")]
        VerticalBar,
        [EnumMember(Value=@"+")]
        Plus,
        [EnumMember(Value=@".")]
        Dot
    }
}