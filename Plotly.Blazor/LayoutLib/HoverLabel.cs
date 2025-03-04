/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The HoverLabel class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class HoverLabel : IEquatable<HoverLabel>
    {
        /// <summary>
        ///     Sets the horizontal alignment of the text content within hover label box.
        ///     Has an effect only if the hover label text spans more two or more lines
        /// </summary>
        [JsonPropertyName(@"align")]
        public Plotly.Blazor.LayoutLib.HoverLabelLib.AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Sets the background color of all hover labels on graph
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the border color of all hover labels on graph.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the default hover label font used by all traces on the graph.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.HoverLabelLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the default length (in number of characters) of the trace name in the
        ///     hover labels for all traces. -1 shows the whole name regardless of length.
        ///     0-3 shows the first 0-3 characters, and an integer &gt;3 will show the whole
        ///     name if it is less than that many characters, but if it is longer, will
        ///     truncate to &#39;namelength - 3&#39; characters and add an ellipsis.
        /// </summary>
        [JsonPropertyName(@"namelength")]
        public int? NameLength { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is HoverLabel other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] HoverLabel other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Align == other.Align ||
                    Align != null &&
                    Align.Equals(other.Align)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    BorderColor == other.BorderColor ||
                    BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    NameLength == other.NameLength ||
                    NameLength != null &&
                    NameLength.Equals(other.NameLength)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Align != null) hashCode = hashCode * 59 + Align.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (NameLength != null) hashCode = hashCode * 59 + NameLength.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (HoverLabel left, HoverLabel right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (HoverLabel left, HoverLabel right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>HoverLabel</returns>
        public HoverLabel DeepClone()
        {
            return this.Copy();
        }
    }
}