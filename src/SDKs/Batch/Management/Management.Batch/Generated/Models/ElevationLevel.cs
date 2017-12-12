// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ElevationLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElevationLevel
    {
        [EnumMember(Value = "NonAdmin")]
        NonAdmin,
        [EnumMember(Value = "Admin")]
        Admin
    }
    internal static class ElevationLevelEnumExtension
    {
        internal static string ToSerializedValue(this ElevationLevel? value)
        {
            return value == null ? null : ((ElevationLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ElevationLevel value)
        {
            switch( value )
            {
                case ElevationLevel.NonAdmin:
                    return "NonAdmin";
                case ElevationLevel.Admin:
                    return "Admin";
            }
            return null;
        }

        internal static ElevationLevel? ParseElevationLevel(this string value)
        {
            switch( value )
            {
                case "NonAdmin":
                    return ElevationLevel.NonAdmin;
                case "Admin":
                    return ElevationLevel.Admin;
            }
            return null;
        }
    }
}
