// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// Device insight report.
    /// Serialized Name: DeviceInsight
    /// </summary>
    public partial class SphereDeviceInsight
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SphereDeviceInsight"/>. </summary>
        /// <param name="deviceId">
        /// Device ID
        /// Serialized Name: DeviceInsight.deviceId
        /// </param>
        /// <param name="description">
        /// Event description
        /// Serialized Name: DeviceInsight.description
        /// </param>
        /// <param name="startTimestampUtc">
        /// Event start timestamp
        /// Serialized Name: DeviceInsight.startTimestampUtc
        /// </param>
        /// <param name="endTimestampUtc">
        /// Event end timestamp
        /// Serialized Name: DeviceInsight.endTimestampUtc
        /// </param>
        /// <param name="eventCategory">
        /// Event category
        /// Serialized Name: DeviceInsight.eventCategory
        /// </param>
        /// <param name="eventClass">
        /// Event class
        /// Serialized Name: DeviceInsight.eventClass
        /// </param>
        /// <param name="eventType">
        /// Event type
        /// Serialized Name: DeviceInsight.eventType
        /// </param>
        /// <param name="eventCount">
        /// Event count
        /// Serialized Name: DeviceInsight.eventCount
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/>, <paramref name="description"/>, <paramref name="eventCategory"/>, <paramref name="eventClass"/> or <paramref name="eventType"/> is null. </exception>
        internal SphereDeviceInsight(string deviceId, string description, DateTimeOffset startTimestampUtc, DateTimeOffset endTimestampUtc, string eventCategory, string eventClass, string eventType, int eventCount)
        {
            Argument.AssertNotNull(deviceId, nameof(deviceId));
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(eventCategory, nameof(eventCategory));
            Argument.AssertNotNull(eventClass, nameof(eventClass));
            Argument.AssertNotNull(eventType, nameof(eventType));

            DeviceId = deviceId;
            Description = description;
            StartTimestampUtc = startTimestampUtc;
            EndTimestampUtc = endTimestampUtc;
            EventCategory = eventCategory;
            EventClass = eventClass;
            EventType = eventType;
            EventCount = eventCount;
        }

        /// <summary> Initializes a new instance of <see cref="SphereDeviceInsight"/>. </summary>
        /// <param name="deviceId">
        /// Device ID
        /// Serialized Name: DeviceInsight.deviceId
        /// </param>
        /// <param name="description">
        /// Event description
        /// Serialized Name: DeviceInsight.description
        /// </param>
        /// <param name="startTimestampUtc">
        /// Event start timestamp
        /// Serialized Name: DeviceInsight.startTimestampUtc
        /// </param>
        /// <param name="endTimestampUtc">
        /// Event end timestamp
        /// Serialized Name: DeviceInsight.endTimestampUtc
        /// </param>
        /// <param name="eventCategory">
        /// Event category
        /// Serialized Name: DeviceInsight.eventCategory
        /// </param>
        /// <param name="eventClass">
        /// Event class
        /// Serialized Name: DeviceInsight.eventClass
        /// </param>
        /// <param name="eventType">
        /// Event type
        /// Serialized Name: DeviceInsight.eventType
        /// </param>
        /// <param name="eventCount">
        /// Event count
        /// Serialized Name: DeviceInsight.eventCount
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereDeviceInsight(string deviceId, string description, DateTimeOffset startTimestampUtc, DateTimeOffset endTimestampUtc, string eventCategory, string eventClass, string eventType, int eventCount, Dictionary<string, BinaryData> rawData)
        {
            DeviceId = deviceId;
            Description = description;
            StartTimestampUtc = startTimestampUtc;
            EndTimestampUtc = endTimestampUtc;
            EventCategory = eventCategory;
            EventClass = eventClass;
            EventType = eventType;
            EventCount = eventCount;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SphereDeviceInsight"/> for deserialization. </summary>
        internal SphereDeviceInsight()
        {
        }

        /// <summary>
        /// Device ID
        /// Serialized Name: DeviceInsight.deviceId
        /// </summary>
        public string DeviceId { get; }
        /// <summary>
        /// Event description
        /// Serialized Name: DeviceInsight.description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Event start timestamp
        /// Serialized Name: DeviceInsight.startTimestampUtc
        /// </summary>
        public DateTimeOffset StartTimestampUtc { get; }
        /// <summary>
        /// Event end timestamp
        /// Serialized Name: DeviceInsight.endTimestampUtc
        /// </summary>
        public DateTimeOffset EndTimestampUtc { get; }
        /// <summary>
        /// Event category
        /// Serialized Name: DeviceInsight.eventCategory
        /// </summary>
        public string EventCategory { get; }
        /// <summary>
        /// Event class
        /// Serialized Name: DeviceInsight.eventClass
        /// </summary>
        public string EventClass { get; }
        /// <summary>
        /// Event type
        /// Serialized Name: DeviceInsight.eventType
        /// </summary>
        public string EventType { get; }
        /// <summary>
        /// Event count
        /// Serialized Name: DeviceInsight.eventCount
        /// </summary>
        public int EventCount { get; }
    }
}
