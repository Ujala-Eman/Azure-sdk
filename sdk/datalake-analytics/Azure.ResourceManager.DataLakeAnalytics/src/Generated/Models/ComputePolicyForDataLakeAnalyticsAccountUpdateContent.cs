// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to update a compute policy while updating a Data Lake Analytics account.
    /// Serialized Name: UpdateComputePolicyWithAccountParameters
    /// </summary>
    public partial class ComputePolicyForDataLakeAnalyticsAccountUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="ComputePolicyForDataLakeAnalyticsAccountUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the compute policy to update.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.name
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ComputePolicyForDataLakeAnalyticsAccountUpdateContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ComputePolicyForDataLakeAnalyticsAccountUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the compute policy to update.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.name
        /// </param>
        /// <param name="objectId">
        /// The AAD object identifier for the entity to create a policy for.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.objectId
        /// </param>
        /// <param name="objectType">
        /// The type of AAD object the object identifier refers to.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.objectType
        /// </param>
        /// <param name="maxDegreeOfParallelismPerJob">
        /// The maximum degree of parallelism per job this user can use to submit jobs. This property, the min priority per job property, or both must be passed.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.maxDegreeOfParallelismPerJob
        /// </param>
        /// <param name="minPriorityPerJob">
        /// The minimum priority per job this user can use to submit jobs. This property, the max degree of parallelism per job property, or both must be passed.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.minPriorityPerJob
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputePolicyForDataLakeAnalyticsAccountUpdateContent(string name, Guid? objectId, AadObjectIdentifierType? objectType, int? maxDegreeOfParallelismPerJob, int? minPriorityPerJob, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ObjectId = objectId;
            ObjectType = objectType;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputePolicyForDataLakeAnalyticsAccountUpdateContent"/> for deserialization. </summary>
        internal ComputePolicyForDataLakeAnalyticsAccountUpdateContent()
        {
        }

        /// <summary>
        /// The unique name of the compute policy to update.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The AAD object identifier for the entity to create a policy for.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.objectId
        /// </summary>
        public Guid? ObjectId { get; set; }
        /// <summary>
        /// The type of AAD object the object identifier refers to.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.objectType
        /// </summary>
        public AadObjectIdentifierType? ObjectType { get; set; }
        /// <summary>
        /// The maximum degree of parallelism per job this user can use to submit jobs. This property, the min priority per job property, or both must be passed.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.maxDegreeOfParallelismPerJob
        /// </summary>
        public int? MaxDegreeOfParallelismPerJob { get; set; }
        /// <summary>
        /// The minimum priority per job this user can use to submit jobs. This property, the max degree of parallelism per job property, or both must be passed.
        /// Serialized Name: UpdateComputePolicyWithAccountParameters.properties.minPriorityPerJob
        /// </summary>
        public int? MinPriorityPerJob { get; set; }
    }
}
