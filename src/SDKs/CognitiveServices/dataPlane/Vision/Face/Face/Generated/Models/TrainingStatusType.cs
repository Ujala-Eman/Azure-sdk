// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TrainingStatusType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrainingStatusType
    {
        [EnumMember(Value = "nonstarted")]
        Nonstarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed
    }
    internal static class TrainingStatusTypeEnumExtension
    {
        internal static string ToSerializedValue(this TrainingStatusType? value)
        {
            return value == null ? null : ((TrainingStatusType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TrainingStatusType value)
        {
            switch( value )
            {
                case TrainingStatusType.Nonstarted:
                    return "nonstarted";
                case TrainingStatusType.Running:
                    return "running";
                case TrainingStatusType.Succeeded:
                    return "succeeded";
                case TrainingStatusType.Failed:
                    return "failed";
            }
            return null;
        }

        internal static TrainingStatusType? ParseTrainingStatusType(this string value)
        {
            switch( value )
            {
                case "nonstarted":
                    return TrainingStatusType.Nonstarted;
                case "running":
                    return TrainingStatusType.Running;
                case "succeeded":
                    return TrainingStatusType.Succeeded;
                case "failed":
                    return TrainingStatusType.Failed;
            }
            return null;
        }
    }
}
