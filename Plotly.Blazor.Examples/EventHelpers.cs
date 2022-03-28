using System;
using Microsoft.AspNetCore.Components;
using Plotly.Blazor.Traces;

namespace Plotly.Blazor.Examples
{

    public class XYClickEventArgs : EventArgs
    {
        public string X { get; set; }
        public int Y { get; set; }
    }

    public class PieClickEventArgs : EventArgs
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }
    
    public class PieHoverEventArgs : EventArgs
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }
    
    public class PlotlyClickEvent : EventArgs
    {
        public Surface Value { get; set; }
        public string ChartType { get; set; }
    }
    
    public class NoDataEventArgs : EventArgs { }

    [EventHandler("onplotly_click_xy", typeof(XYClickEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    [EventHandler("onplotly_click_pie", typeof(PieClickEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    [EventHandler("onplotly_hover_pie", typeof(PieHoverEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    [EventHandler("onplotly_doubleclick", typeof(NoDataEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    
    [EventHandler("onplotly_click", typeof(PlotlyClickEvent), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers { }
}