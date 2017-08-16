// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PerformanceLevelUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PerformanceLevelUnit
    {
        [EnumMember(Value = "DTU")]
        DTU
    }
    internal static class PerformanceLevelUnitEnumExtension
    {
        internal static string ToSerializedValue(this PerformanceLevelUnit? value)  =>
            value == null ? null : ((PerformanceLevelUnit)value).ToSerializedValue();

        internal static string ToSerializedValue(this PerformanceLevelUnit value)
        {
            switch( value )
            {
                case PerformanceLevelUnit.DTU:
                    return "DTU";
            }
            return null;
        }

        internal static PerformanceLevelUnit? ParsePerformanceLevelUnit(this string value)
        {
            switch( value )
            {
                case "DTU":
                    return PerformanceLevelUnit.DTU;
            }
            return null;
        }
    }
}
