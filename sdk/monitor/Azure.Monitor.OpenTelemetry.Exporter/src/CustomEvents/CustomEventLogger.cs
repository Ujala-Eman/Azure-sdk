﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Azure.Monitor.OpenTelemetry.Events
{
    /// <summary>
    /// Default logger for logging Application Insights custom events.
    /// </summary>
    public sealed class CustomEventLogger : ICustomEventLogger
    {
        private static readonly Func<IReadOnlyList<KeyValuePair<string, object?>>?, Exception?, string> s_formatter = (state, ex) =>
        {
            return "CustomEvent";
        };

        private readonly ILogger _logger;

        /// <summary>
        /// Creates an instance of CustomEventLogger to log custom events.
        /// </summary>
        /// <param name="loggerFactory">LoggerFactory instance for logging events.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CustomEventLogger(ILoggerFactory loggerFactory)
        {
            if (loggerFactory == null)
                throw new ArgumentNullException(nameof(loggerFactory));

            _logger = loggerFactory.CreateLogger("Azure.Monitor.OpenTelemetry.CustomEvents");
        }

        /// <inheritdoc/>
        public void TrackEvent(string name, IReadOnlyList<KeyValuePair<string, object?>>? attributes = null)
        {
            // Setting the loglevel to critical to ensure events are not filtered.
            _logger.Log(LogLevel.Critical, eventId: new EventId(1, name), attributes, exception: null, formatter: s_formatter);
        }
    }
}
