// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DisableJobOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisableJobOption
    {
        [EnumMember(Value = "requeue")]
        Requeue,
        [EnumMember(Value = "terminate")]
        Terminate,
        [EnumMember(Value = "wait")]
        Wait
    }
    internal static class DisableJobOptionEnumExtension
    {
        internal static string ToSerializedValue(this DisableJobOption? value)
        {
            return value == null ? null : ((DisableJobOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DisableJobOption value)
        {
            switch( value )
            {
                case DisableJobOption.Requeue:
                    return "requeue";
                case DisableJobOption.Terminate:
                    return "terminate";
                case DisableJobOption.Wait:
                    return "wait";
            }
            return null;
        }

        internal static DisableJobOption? ParseDisableJobOption(this string value)
        {
            switch( value )
            {
                case "requeue":
                    return DisableJobOption.Requeue;
                case "terminate":
                    return DisableJobOption.Terminate;
                case "wait":
                    return DisableJobOption.Wait;
            }
            return null;
        }
    }
}
