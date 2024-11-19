// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the security posture to be used in the scale set. Minimum api-version: 2023-03-01. </summary>
    public partial class ComputeSecurityPostureReference
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputeSecurityPostureReference"/>. </summary>
        /// <param name="id"> The security posture reference id in the form of /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|latest. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ComputeSecurityPostureReference(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            ExcludeExtensionNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSecurityPostureReference"/>. </summary>
        /// <param name="id"> The security posture reference id in the form of /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|latest. </param>
        /// <param name="excludeExtensionNames"> The list of virtual machine extension names to exclude when applying the security posture. </param>
        /// <param name="isOverridable"> Whether the security posture can be overridden by the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeSecurityPostureReference(ResourceIdentifier id, IList<string> excludeExtensionNames, bool? isOverridable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ExcludeExtensionNames = excludeExtensionNames;
            IsOverridable = isOverridable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSecurityPostureReference"/> for deserialization. </summary>
        internal ComputeSecurityPostureReference()
        {
        }

        /// <summary> The security posture reference id in the form of /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|latest. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The list of virtual machine extension names to exclude when applying the security posture. </summary>
        public IList<string> ExcludeExtensionNames { get; }
        /// <summary> Whether the security posture can be overridden by the user. </summary>
        public bool? IsOverridable { get; set; }
    }
}
