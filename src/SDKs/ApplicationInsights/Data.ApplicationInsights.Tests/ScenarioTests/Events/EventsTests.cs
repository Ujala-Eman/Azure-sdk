﻿using Microsoft.Azure.ApplicationInsights;
using Microsoft.Azure.ApplicationInsights.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Data.ApplicationInsights.Tests.Events
{
    public class EventsTests : EventsTestBase
    {
        private const int TopCount = 10;
        private readonly TimeSpan Timespan = new TimeSpan(1, 0, 0, 0);

        [Fact]
        public async Task GetAllEvents()
        {
            using (var ctx = MockContext.Start(GetType().FullName))
            {
                var client = GetClient(ctx);
                var events = await client.GetEventsAsync(EventType.All, timespan: Timespan, top: TopCount);

                Assert.NotNull(events);
                Assert.NotNull(events.Value);
                Assert.True(events.Value.Count <= TopCount);

                foreach (var evnt in events.Value)
                {
                    var eventType = GetEventType(evnt);
                    if (!eventType.HasValue) continue; // This means there is a new type that we don't support here yet
                    AssertEvent(evnt, eventType.Value);
                }
            }
        }

        [Theory]
        [InlineData(EventType.Traces)]
        [InlineData(EventType.CustomEvents)]
        [InlineData(EventType.PageViews)]
        [InlineData(EventType.BrowserTimings)]
        [InlineData(EventType.Requests)]
        [InlineData(EventType.Dependencies)]
        [InlineData(EventType.Exceptions)]
        [InlineData(EventType.AvailabilityResults)]
        [InlineData(EventType.PerformanceCounters)]
        [InlineData(EventType.CustomMetrics)]
        public async Task GetEventsByType(EventType eventType)
        {
            using (var ctx = MockContext.Start(GetType().FullName, $"GetEventsByType.{eventType}"))
            {
                var client = GetClient(ctx);
                var traces = await client.GetEventsAsync(eventType, timespan: Timespan, top: TopCount);

                Assert.NotNull(traces);
                Assert.NotNull(traces.Value);
                Assert.True(traces.Value.Count <= TopCount);

                var evnt = traces.Value[0];

                AssertEvent(evnt, eventType);

                traces = await client.GetEventAsync(eventType, evnt.Id.Value);

                Assert.NotNull(traces);
                Assert.NotNull(traces.Value);
                Assert.Equal(1, traces.Value.Count);

                evnt = traces.Value[0];

                AssertEvent(evnt, eventType);
            }
        }
    }
}
