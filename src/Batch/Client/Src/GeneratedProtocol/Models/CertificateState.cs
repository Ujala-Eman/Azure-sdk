// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for CertificateState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CertificateState
    {
        [System.Runtime.Serialization.EnumMember(Value = "active")]
        Active,
        [System.Runtime.Serialization.EnumMember(Value = "deleting")]
        Deleting,
        [System.Runtime.Serialization.EnumMember(Value = "deletefailed")]
        Deletefailed
    }
    internal static class CertificateStateEnumExtension
    {
        internal static string ToSerializedValue(this CertificateState? value )  =>
            value == null ? null : (( CertificateState )value).ToSerializedValue();

        internal static string ToSerializedValue(this CertificateState value )
        {
            switch( value )
            {
                case CertificateState.Active:
                    return "active";
                case CertificateState.Deleting:
                    return "deleting";
                case CertificateState.Deletefailed:
                    return "deletefailed";
            }
            return null;
        }

        internal static CertificateState? ParseCertificateState( this string value )
        {
            switch( value )
            {
                case "active":
                    return CertificateState.Active;
                case "deleting":
                    return CertificateState.Deleting;
                case "deletefailed":
                    return CertificateState.Deletefailed;
            }
            return null;
        }
    }
}
