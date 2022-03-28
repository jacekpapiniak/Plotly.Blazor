window.plotlyExampleEvents = {
    plotlyClickXYEventArgsCreator: function (event) {
        return {
            x: event.detail.points[0].x,
            y: event.detail.points[0].y
        };
    },
    plotlyPIEEventArgsCreator: function (event) {
        return {
            label: event.detail.points[0].label,
            value: event.detail.points[0].value
        };
    },
    plotlyNoDataEventArgsCreator: function (event) {
        // No data associated with event
        return { };
    },
    plotlyClickEventArgsCreator: function (event) {
        console.log(event);
        return {
            value: event.detail.points[0].data,
            chartType : event.detail.points[0].fullData.type
        }
    }
}

// Register custom event names and handlers
Blazor.registerCustomEventType('plotly_click_pie', {
    browserEventName: 'plotly_click',
    createEventArgs: plotlyExampleEvents.plotlyPIEEventArgsCreator
});
Blazor.registerCustomEventType('plotly_hover_pie', {
    browserEventName: 'plotly_hover',
    createEventArgs: plotlyExampleEvents.plotlyPIEEventArgsCreator
});
Blazor.registerCustomEventType('plotly_click_xy', {
    browserEventName: 'plotly_click',
    createEventArgs: plotlyExampleEvents.plotlyClickXYEventArgsCreator
});
Blazor.registerCustomEventType('plotly_doubleclick', {
    browserEventName: 'plotly_doubleclick',
    createEventArgs: plotlyExampleEvents.plotlyNoDataEventArgsCreator
});

Blazor.registerCustomEventType('plotly_click', {
    browserEventName: 'plotly_click',
    createEventArgs: plotlyExampleEvents.plotlyClickEventArgsCreator
});