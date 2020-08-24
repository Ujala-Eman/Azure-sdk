// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.AnomalyDetector.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Granularity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Granularity
    {
        [EnumMember(Value = "yearly")]
        Yearly,
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "hourly")]
        Hourly,
        [EnumMember(Value = "minutely")]
        Minutely,
        [EnumMember(Value = "secondly")]
        Secondly
    }
    internal static class GranularityEnumExtension
    {
        internal static string ToSerializedValue(this Granularity? value)
        {
            return value == null ? null : ((Granularity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Granularity value)
        {
            switch( value )
            {
                case Granularity.Yearly:
                    return "yearly";
                case Granularity.Monthly:
                    return "monthly";
                case Granularity.Weekly:
                    return "weekly";
                case Granularity.Daily:
                    return "daily";
                case Granularity.Hourly:
                    return "hourly";
                case Granularity.Minutely:
                    return "minutely";
                case Granularity.Secondly:
                    return "secondly";
            }
            return null;
        }

        internal static Granularity? ParseGranularity(this string value)
        {
            switch( value )
            {
                case "yearly":
                    return Granularity.Yearly;
                case "monthly":
                    return Granularity.Monthly;
                case "weekly":
                    return Granularity.Weekly;
                case "daily":
                    return Granularity.Daily;
                case "hourly":
                    return Granularity.Hourly;
                case "minutely":
                    return Granularity.Minutely;
                case "secondly":
                    return Granularity.Secondly;
            }
            return null;
        }
    }
}
