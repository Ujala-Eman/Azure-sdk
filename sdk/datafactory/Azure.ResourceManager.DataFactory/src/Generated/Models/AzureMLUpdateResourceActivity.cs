// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Update Resource management activity. </summary>
    public partial class AzureMLUpdateResourceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureMLUpdateResourceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="trainedModelName"> Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string). </param>
        /// <param name="trainedModelLinkedServiceName"> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </param>
        /// <param name="trainedModelFilePath"> The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="trainedModelName"/>, <paramref name="trainedModelLinkedServiceName"/> or <paramref name="trainedModelFilePath"/> is null. </exception>
        public AzureMLUpdateResourceActivity(string name, BinaryData trainedModelName, FactoryLinkedServiceReference trainedModelLinkedServiceName, BinaryData trainedModelFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (trainedModelName == null)
            {
                throw new ArgumentNullException(nameof(trainedModelName));
            }
            if (trainedModelLinkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(trainedModelLinkedServiceName));
            }
            if (trainedModelFilePath == null)
            {
                throw new ArgumentNullException(nameof(trainedModelFilePath));
            }

            TrainedModelName = trainedModelName;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelFilePath = trainedModelFilePath;
            ActivityType = "AzureMLUpdateResource";
        }

        /// <summary> Initializes a new instance of AzureMLUpdateResourceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="trainedModelName"> Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string). </param>
        /// <param name="trainedModelLinkedServiceName"> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </param>
        /// <param name="trainedModelFilePath"> The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string). </param>
        internal AzureMLUpdateResourceActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData trainedModelName, FactoryLinkedServiceReference trainedModelLinkedServiceName, BinaryData trainedModelFilePath) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            TrainedModelName = trainedModelName;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelFilePath = trainedModelFilePath;
            ActivityType = activityType ?? "AzureMLUpdateResource";
        }

        /// <summary>
        /// Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData TrainedModelName { get; set; }
        /// <summary> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </summary>
        public FactoryLinkedServiceReference TrainedModelLinkedServiceName { get; set; }
        /// <summary>
        /// The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData TrainedModelFilePath { get; set; }
    }
}
