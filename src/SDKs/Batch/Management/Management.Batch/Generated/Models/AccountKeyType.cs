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
    /// Defines values for AccountKeyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountKeyType
    {
        [EnumMember(Value = "Primary")]
        Primary,
        [EnumMember(Value = "Secondary")]
        Secondary
    }
    internal static class AccountKeyTypeEnumExtension
    {
        internal static string ToSerializedValue(this AccountKeyType? value)
        {
            return value == null ? null : ((AccountKeyType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AccountKeyType value)
        {
            switch( value )
            {
                case AccountKeyType.Primary:
                    return "Primary";
                case AccountKeyType.Secondary:
                    return "Secondary";
            }
            return null;
        }

        internal static AccountKeyType? ParseAccountKeyType(this string value)
        {
            switch( value )
            {
                case "Primary":
                    return AccountKeyType.Primary;
                case "Secondary":
                    return AccountKeyType.Secondary;
            }
            return null;
        }
    }
}
