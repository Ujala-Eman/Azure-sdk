// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> This is the storage profile of a Gallery Image Version. </summary>
    public partial class SharedGalleryImageVersionStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageVersionStorageProfile"/>. </summary>
        internal SharedGalleryImageVersionStorageProfile()
        {
            DataDiskImages = new ChangeTrackingList<SharedGalleryDataDiskImage>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageVersionStorageProfile"/>. </summary>
        /// <param name="osDiskImage"> This is the OS disk image. </param>
        /// <param name="dataDiskImages"> A list of data disk images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryImageVersionStorageProfile(SharedGalleryOSDiskImage osDiskImage, IReadOnlyList<SharedGalleryDataDiskImage> dataDiskImages, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This is the OS disk image. </summary>
        public SharedGalleryOSDiskImage OSDiskImage { get; }
        /// <summary> A list of data disk images. </summary>
        public IReadOnlyList<SharedGalleryDataDiskImage> DataDiskImages { get; }
    }
}
