// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LinkTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkTypes
    {
        [EnumMember(Value = "UpdateAlways")]
        UpdateAlways,
        [EnumMember(Value = "CopyIfNull")]
        CopyIfNull
    }
    internal static class LinkTypesEnumExtension
    {
        internal static string ToSerializedValue(this LinkTypes? value)
        {
            return value == null ? null : ((LinkTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LinkTypes value)
        {
            switch( value )
            {
                case LinkTypes.UpdateAlways:
                    return "UpdateAlways";
                case LinkTypes.CopyIfNull:
                    return "CopyIfNull";
            }
            return null;
        }

        internal static LinkTypes? ParseLinkTypes(this string value)
        {
            switch( value )
            {
                case "UpdateAlways":
                    return LinkTypes.UpdateAlways;
                case "CopyIfNull":
                    return LinkTypes.CopyIfNull;
            }
            return null;
        }
    }
}
