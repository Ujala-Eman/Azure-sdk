// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Evaluation Schedule Definition. </summary>
    public partial class EvaluationSchedule
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

        /// <summary> Initializes a new instance of <see cref="EvaluationSchedule"/>. </summary>
        /// <param name="data"> Data for evaluation. </param>
        /// <param name="evaluators"> Evaluators to be used for the evaluation. </param>
        /// <param name="trigger">
        /// Trigger for the evaluation.
        /// Please note <see cref="Projects.Trigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="RecurrenceTrigger"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/>, <paramref name="evaluators"/> or <paramref name="trigger"/> is null. </exception>
        public EvaluationSchedule(ApplicationInsightsConfiguration data, IDictionary<string, EvaluatorConfiguration> evaluators, Trigger trigger)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(evaluators, nameof(evaluators));
            Argument.AssertNotNull(trigger, nameof(trigger));

            Data = data;
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
            Evaluators = evaluators;
            Trigger = trigger;
        }

        /// <summary> Initializes a new instance of <see cref="EvaluationSchedule"/>. </summary>
        /// <param name="name"> Name of the schedule, which also serves as the unique identifier for the evaluation. </param>
        /// <param name="data"> Data for evaluation. </param>
        /// <param name="description"> Description of the evaluation. It can be used to store additional information about the evaluation and is mutable. </param>
        /// <param name="systemData"> Metadata containing createdBy and modifiedBy information. </param>
        /// <param name="provisioningStatus"> Status of the evaluation. It is set by service and is read-only. </param>
        /// <param name="tags"> Evaluation's tags. Unlike properties, tags are fully mutable. </param>
        /// <param name="properties"> Evaluation's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed. </param>
        /// <param name="evaluators"> Evaluators to be used for the evaluation. </param>
        /// <param name="trigger">
        /// Trigger for the evaluation.
        /// Please note <see cref="Projects.Trigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="RecurrenceTrigger"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EvaluationSchedule(string name, ApplicationInsightsConfiguration data, string description, SystemData systemData, string provisioningStatus, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, EvaluatorConfiguration> evaluators, Trigger trigger, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Data = data;
            Description = description;
            SystemData = systemData;
            ProvisioningStatus = provisioningStatus;
            Tags = tags;
            Properties = properties;
            Evaluators = evaluators;
            Trigger = trigger;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EvaluationSchedule"/> for deserialization. </summary>
        internal EvaluationSchedule()
        {
        }

        /// <summary> Name of the schedule, which also serves as the unique identifier for the evaluation. </summary>
        public string Name { get; }
        /// <summary> Data for evaluation. </summary>
        public ApplicationInsightsConfiguration Data { get; set; }
        /// <summary> Description of the evaluation. It can be used to store additional information about the evaluation and is mutable. </summary>
        public string Description { get; set; }
        /// <summary> Metadata containing createdBy and modifiedBy information. </summary>
        public SystemData SystemData { get; }
        /// <summary> Status of the evaluation. It is set by service and is read-only. </summary>
        public string ProvisioningStatus { get; }
        /// <summary> Evaluation's tags. Unlike properties, tags are fully mutable. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Evaluation's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Evaluators to be used for the evaluation. </summary>
        public IDictionary<string, EvaluatorConfiguration> Evaluators { get; }
        /// <summary>
        /// Trigger for the evaluation.
        /// Please note <see cref="Projects.Trigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="RecurrenceTrigger"/>.
        /// </summary>
        public Trigger Trigger { get; set; }
    }
}
