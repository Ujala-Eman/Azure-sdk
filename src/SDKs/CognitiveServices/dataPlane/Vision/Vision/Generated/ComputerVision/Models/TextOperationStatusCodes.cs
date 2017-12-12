// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextOperationStatusCodes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextOperationStatusCodes
    {
        [EnumMember(Value = "Not Started")]
        NotStarted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    internal static class TextOperationStatusCodesEnumExtension
    {
        internal static string ToSerializedValue(this TextOperationStatusCodes? value)
        {
            return value == null ? null : ((TextOperationStatusCodes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextOperationStatusCodes value)
        {
            switch( value )
            {
                case TextOperationStatusCodes.NotStarted:
                    return "Not Started";
                case TextOperationStatusCodes.Running:
                    return "Running";
                case TextOperationStatusCodes.Failed:
                    return "Failed";
                case TextOperationStatusCodes.Succeeded:
                    return "Succeeded";
            }
            return null;
        }

        internal static TextOperationStatusCodes? ParseTextOperationStatusCodes(this string value)
        {
            switch( value )
            {
                case "Not Started":
                    return TextOperationStatusCodes.NotStarted;
                case "Running":
                    return TextOperationStatusCodes.Running;
                case "Failed":
                    return TextOperationStatusCodes.Failed;
                case "Succeeded":
                    return TextOperationStatusCodes.Succeeded;
            }
            return null;
        }
    }
}
