/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Choropleth class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Choropleth : ITrace, IEquatable<Choropleth>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Choropleth;

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.ChoroplethLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>zmin</c> and
        ///     <c>zmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>customdata</c>.
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the key in GeoJSON features which is used as id to match the items
        ///     included in the <c>locations</c> array. Only has an effect when <c>geojson</c>
        ///     is set. Support nested property, for example <c>properties.name</c>.
        /// </summary>
        [JsonPropertyName(@"featureidkey")]
        public string FeatureIdKey { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s geospatial coordinates and a geographic
        ///     map. If <c>geo</c> (the default value), the geospatial coordinates refer
        ///     to <c>layout.geo</c>. If <c>geo2</c>, the geospatial coordinates refer to
        ///     <c>layout.geo2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"geo")]
        public string Geo { get; set;} 

        /// <summary>
        ///     Sets optional GeoJSON data associated with this trace. If not given, the
        ///     features on the base map are used. It can be set as a valid GeoJSON object
        ///     or as a URL string. Note that we only accept GeoJSONs of type <c>FeatureCollection</c>
        ///     or <c>Feature</c> with geometries of type <c>Polygon</c> or <c>MultiPolygon</c>.
        /// </summary>
        [JsonPropertyName(@"geojson")]
        public object GeoJson { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.ChoroplethLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public IList<Plotly.Blazor.Traces.ChoroplethLib.HoverInfoFlag?> HoverInfoArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>hoverinfo</c>.
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.ChoroplethLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot; as well as %{xother},
        ///     {%_xother}, {%_xother_}, {%xother_}. When showing info for several points,
        ///     <c>xother</c> will be added to those with different x positions from the
        ///     first point. An underscore before or after <c>(x|y)other</c> will add a
        ///     space on that side, only when this field is shown. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-format/tree/v1.4.5#d3-format for
        ///     details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format for details
        ///     on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot; as well as %{xother},
        ///     {%_xother}, {%_xother_}, {%xother_}. When showing info for several points,
        ///     <c>xother</c> will be added to those with different x positions from the
        ///     first point. An underscore before or after <c>(x|y)other</c> will add a
        ///     space on that side, only when this field is shown. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-format/tree/v1.4.5#d3-format for
        ///     details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format for details
        ///     on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public IList<string> HoverTemplateArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>hovertemplate</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public IList<string> HoverTextArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>hovertext</c>.
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>ids</c>.
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Gets or sets the LegendGroupTitle.
        /// </summary>
        [JsonPropertyName(@"legendgrouptitle")]
        public Plotly.Blazor.Traces.ChoroplethLib.LegendGroupTitle LegendGroupTitle { get; set;} 

        /// <summary>
        ///     Sets the legend rank for this trace. Items and groups with smaller ranks
        ///     are presented on top/left side while with `<c>reversed</c> <c>legend.traceorder</c>
        ///     they are on bottom/right side. The default legendrank is 1000, so that you
        ///     can use ranks less than 1000 to place certain items before all unranked
        ///     items, and ranks greater than 1000 to go after all unranked items.
        /// </summary>
        [JsonPropertyName(@"legendrank")]
        public decimal? LegendRank { get; set;} 

        /// <summary>
        ///     Determines the set of locations used to match entries in <c>locations</c>
        ///     to regions on the map. Values <c>ISO-3</c>, <c>USA-states</c>, &#39;country
        ///     names&#39; correspond to features on the base map and value <c>geojson-id</c>
        ///     corresponds to features from a custom GeoJSON linked to the <c>geojson</c>
        ///     attribute.
        /// </summary>
        [JsonPropertyName(@"locationmode")]
        public Plotly.Blazor.Traces.ChoroplethLib.LocationModeEnum? LocationMode { get; set;} 

        /// <summary>
        ///     Sets the coordinates via location IDs or names. See <c>locationmode</c>
        ///     for more info.
        /// </summary>
        [JsonPropertyName(@"locations")]
        public IList<object> Locations { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>locations</c>.
        /// </summary>
        [JsonPropertyName(@"locationssrc")]
        public string LocationsSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.ChoroplethLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public IList<object> MetaArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>meta</c>.
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Plotly.Blazor.Traces.ChoroplethLib.Selected Selected { get; set;} 

        /// <summary>
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.ChoroplethLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each location.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each location.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public IList<string> TextArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public IList<ITransform> Transforms { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Plotly.Blazor.Traces.ChoroplethLib.Unselected Unselected { get; set;} 

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.ChoroplethLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the color values.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///      Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public decimal? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public decimal? ZMid { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public decimal? ZMin { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>z</c>.
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Choropleth other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Choropleth other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    AutoColorScale == other.AutoColorScale ||
                    AutoColorScale != null &&
                    AutoColorScale.Equals(other.AutoColorScale)
                ) && 
                (
                    ColorAxis == other.ColorAxis ||
                    ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
                ) && 
                (
                    ColorBar == other.ColorBar ||
                    ColorBar != null &&
                    ColorBar.Equals(other.ColorBar)
                ) && 
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    Equals(CustomData, other.CustomData) ||
                    CustomData != null && other.CustomData != null &&
                    CustomData.SequenceEqual(other.CustomData)
                ) &&
                (
                    CustomDataSrc == other.CustomDataSrc ||
                    CustomDataSrc != null &&
                    CustomDataSrc.Equals(other.CustomDataSrc)
                ) && 
                (
                    FeatureIdKey == other.FeatureIdKey ||
                    FeatureIdKey != null &&
                    FeatureIdKey.Equals(other.FeatureIdKey)
                ) && 
                (
                    Geo == other.Geo ||
                    Geo != null &&
                    Geo.Equals(other.Geo)
                ) && 
                (
                    GeoJson == other.GeoJson ||
                    GeoJson != null &&
                    GeoJson.Equals(other.GeoJson)
                ) && 
                (
                    HoverInfo == other.HoverInfo ||
                    HoverInfo != null &&
                    HoverInfo.Equals(other.HoverInfo)
                ) && 
                (
                    Equals(HoverInfoArray, other.HoverInfoArray) ||
                    HoverInfoArray != null && other.HoverInfoArray != null &&
                    HoverInfoArray.SequenceEqual(other.HoverInfoArray)
                ) &&
                (
                    HoverInfoSrc == other.HoverInfoSrc ||
                    HoverInfoSrc != null &&
                    HoverInfoSrc.Equals(other.HoverInfoSrc)
                ) && 
                (
                    HoverLabel == other.HoverLabel ||
                    HoverLabel != null &&
                    HoverLabel.Equals(other.HoverLabel)
                ) && 
                (
                    HoverTemplate == other.HoverTemplate ||
                    HoverTemplate != null &&
                    HoverTemplate.Equals(other.HoverTemplate)
                ) && 
                (
                    Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null &&
                    HoverTemplateArray.SequenceEqual(other.HoverTemplateArray)
                ) &&
                (
                    HoverTemplateSrc == other.HoverTemplateSrc ||
                    HoverTemplateSrc != null &&
                    HoverTemplateSrc.Equals(other.HoverTemplateSrc)
                ) && 
                (
                    HoverText == other.HoverText ||
                    HoverText != null &&
                    HoverText.Equals(other.HoverText)
                ) && 
                (
                    Equals(HoverTextArray, other.HoverTextArray) ||
                    HoverTextArray != null && other.HoverTextArray != null &&
                    HoverTextArray.SequenceEqual(other.HoverTextArray)
                ) &&
                (
                    HoverTextSrc == other.HoverTextSrc ||
                    HoverTextSrc != null &&
                    HoverTextSrc.Equals(other.HoverTextSrc)
                ) && 
                (
                    Equals(Ids, other.Ids) ||
                    Ids != null && other.Ids != null &&
                    Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    IdsSrc == other.IdsSrc ||
                    IdsSrc != null &&
                    IdsSrc.Equals(other.IdsSrc)
                ) && 
                (
                    LegendGroup == other.LegendGroup ||
                    LegendGroup != null &&
                    LegendGroup.Equals(other.LegendGroup)
                ) && 
                (
                    LegendGroupTitle == other.LegendGroupTitle ||
                    LegendGroupTitle != null &&
                    LegendGroupTitle.Equals(other.LegendGroupTitle)
                ) && 
                (
                    LegendRank == other.LegendRank ||
                    LegendRank != null &&
                    LegendRank.Equals(other.LegendRank)
                ) && 
                (
                    LocationMode == other.LocationMode ||
                    LocationMode != null &&
                    LocationMode.Equals(other.LocationMode)
                ) && 
                (
                    Equals(Locations, other.Locations) ||
                    Locations != null && other.Locations != null &&
                    Locations.SequenceEqual(other.Locations)
                ) &&
                (
                    LocationsSrc == other.LocationsSrc ||
                    LocationsSrc != null &&
                    LocationsSrc.Equals(other.LocationsSrc)
                ) && 
                (
                    Marker == other.Marker ||
                    Marker != null &&
                    Marker.Equals(other.Marker)
                ) && 
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
                ) && 
                (
                    Equals(MetaArray, other.MetaArray) ||
                    MetaArray != null && other.MetaArray != null &&
                    MetaArray.SequenceEqual(other.MetaArray)
                ) &&
                (
                    MetaSrc == other.MetaSrc ||
                    MetaSrc != null &&
                    MetaSrc.Equals(other.MetaSrc)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ReverseScale == other.ReverseScale ||
                    ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    Selected == other.Selected ||
                    Selected != null &&
                    Selected.Equals(other.Selected)
                ) && 
                (
                    SelectedPoints == other.SelectedPoints ||
                    SelectedPoints != null &&
                    SelectedPoints.Equals(other.SelectedPoints)
                ) && 
                (
                    ShowLegend == other.ShowLegend ||
                    ShowLegend != null &&
                    ShowLegend.Equals(other.ShowLegend)
                ) && 
                (
                    ShowScale == other.ShowScale ||
                    ShowScale != null &&
                    ShowScale.Equals(other.ShowScale)
                ) && 
                (
                    Stream == other.Stream ||
                    Stream != null &&
                    Stream.Equals(other.Stream)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Equals(TextArray, other.TextArray) ||
                    TextArray != null && other.TextArray != null &&
                    TextArray.SequenceEqual(other.TextArray)
                ) &&
                (
                    TextSrc == other.TextSrc ||
                    TextSrc != null &&
                    TextSrc.Equals(other.TextSrc)
                ) && 
                (
                    Equals(Transforms, other.Transforms) ||
                    Transforms != null && other.Transforms != null &&
                    Transforms.SequenceEqual(other.Transforms)
                ) &&
                (
                    UId == other.UId ||
                    UId != null &&
                    UId.Equals(other.UId)
                ) && 
                (
                    UiRevision == other.UiRevision ||
                    UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Unselected == other.Unselected ||
                    Unselected != null &&
                    Unselected.Equals(other.Unselected)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Equals(Z, other.Z) ||
                    Z != null && other.Z != null &&
                    Z.SequenceEqual(other.Z)
                ) &&
                (
                    ZAuto == other.ZAuto ||
                    ZAuto != null &&
                    ZAuto.Equals(other.ZAuto)
                ) && 
                (
                    ZMax == other.ZMax ||
                    ZMax != null &&
                    ZMax.Equals(other.ZMax)
                ) && 
                (
                    ZMid == other.ZMid ||
                    ZMid != null &&
                    ZMid.Equals(other.ZMid)
                ) && 
                (
                    ZMin == other.ZMin ||
                    ZMin != null &&
                    ZMin.Equals(other.ZMin)
                ) && 
                (
                    ZSrc == other.ZSrc ||
                    ZSrc != null &&
                    ZSrc.Equals(other.ZSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (AutoColorScale != null) hashCode = hashCode * 59 + AutoColorScale.GetHashCode();
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (ColorBar != null) hashCode = hashCode * 59 + ColorBar.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (FeatureIdKey != null) hashCode = hashCode * 59 + FeatureIdKey.GetHashCode();
                if (Geo != null) hashCode = hashCode * 59 + Geo.GetHashCode();
                if (GeoJson != null) hashCode = hashCode * 59 + GeoJson.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverInfoArray != null) hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();
                if (HoverInfoSrc != null) hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (HoverTemplate != null) hashCode = hashCode * 59 + HoverTemplate.GetHashCode();
                if (HoverTemplateArray != null) hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();
                if (HoverTemplateSrc != null) hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (HoverTextArray != null) hashCode = hashCode * 59 + HoverTextArray.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (LegendGroup != null) hashCode = hashCode * 59 + LegendGroup.GetHashCode();
                if (LegendGroupTitle != null) hashCode = hashCode * 59 + LegendGroupTitle.GetHashCode();
                if (LegendRank != null) hashCode = hashCode * 59 + LegendRank.GetHashCode();
                if (LocationMode != null) hashCode = hashCode * 59 + LocationMode.GetHashCode();
                if (Locations != null) hashCode = hashCode * 59 + Locations.GetHashCode();
                if (LocationsSrc != null) hashCode = hashCode * 59 + LocationsSrc.GetHashCode();
                if (Marker != null) hashCode = hashCode * 59 + Marker.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (Selected != null) hashCode = hashCode * 59 + Selected.GetHashCode();
                if (SelectedPoints != null) hashCode = hashCode * 59 + SelectedPoints.GetHashCode();
                if (ShowLegend != null) hashCode = hashCode * 59 + ShowLegend.GetHashCode();
                if (ShowScale != null) hashCode = hashCode * 59 + ShowScale.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextArray != null) hashCode = hashCode * 59 + TextArray.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (Transforms != null) hashCode = hashCode * 59 + Transforms.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Unselected != null) hashCode = hashCode * 59 + Unselected.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                if (ZAuto != null) hashCode = hashCode * 59 + ZAuto.GetHashCode();
                if (ZMax != null) hashCode = hashCode * 59 + ZMax.GetHashCode();
                if (ZMid != null) hashCode = hashCode * 59 + ZMid.GetHashCode();
                if (ZMin != null) hashCode = hashCode * 59 + ZMin.GetHashCode();
                if (ZSrc != null) hashCode = hashCode * 59 + ZSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Choropleth and the right Choropleth.
        /// </summary>
        /// <param name="left">Left Choropleth.</param>
        /// <param name="right">Right Choropleth.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Choropleth left, Choropleth right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Choropleth and the right Choropleth.
        /// </summary>
        /// <param name="left">Left Choropleth.</param>
        /// <param name="right">Right Choropleth.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Choropleth left, Choropleth right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Choropleth</returns>
        public Choropleth DeepClone()
        {
            return this.Copy();
        }
    }
}