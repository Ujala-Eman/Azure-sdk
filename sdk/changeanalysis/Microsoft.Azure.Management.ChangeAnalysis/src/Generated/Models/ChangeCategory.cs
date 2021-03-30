// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.ChangeAnalysis.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ChangeCategory.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangeCategory
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "System")]
        System
    }
    internal static class ChangeCategoryEnumExtension
    {
        internal static string ToSerializedValue(this ChangeCategory? value)
        {
            return value == null ? null : ((ChangeCategory)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ChangeCategory value)
        {
            switch( value )
            {
                case ChangeCategory.User:
                    return "User";
                case ChangeCategory.System:
                    return "System";
            }
            return null;
        }

        internal static ChangeCategory? ParseChangeCategory(this string value)
        {
            switch( value )
            {
                case "User":
                    return ChangeCategory.User;
                case "System":
                    return ChangeCategory.System;
            }
            return null;
        }
    }
}
