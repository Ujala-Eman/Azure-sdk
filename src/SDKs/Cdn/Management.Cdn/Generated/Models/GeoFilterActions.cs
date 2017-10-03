// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GeoFilterActions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeoFilterActions
    {
        [EnumMember(Value = "Block")]
        Block,
        [EnumMember(Value = "Allow")]
        Allow
    }
    internal static class GeoFilterActionsEnumExtension
    {
        internal static string ToSerializedValue(this GeoFilterActions? value)  =>
            value == null ? null : ((GeoFilterActions)value).ToSerializedValue();

        internal static string ToSerializedValue(this GeoFilterActions value)
        {
            switch( value )
            {
                case GeoFilterActions.Block:
                    return "Block";
                case GeoFilterActions.Allow:
                    return "Allow";
            }
            return null;
        }

        internal static GeoFilterActions? ParseGeoFilterActions(this string value)
        {
            switch( value )
            {
                case "Block":
                    return GeoFilterActions.Block;
                case "Allow":
                    return GeoFilterActions.Allow;
            }
            return null;
        }
    }
}
