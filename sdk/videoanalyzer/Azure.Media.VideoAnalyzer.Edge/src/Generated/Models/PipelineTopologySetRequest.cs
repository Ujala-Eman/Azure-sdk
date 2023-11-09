// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Creates a new pipeline topology or updates an existing one. </summary>
    public partial class PipelineTopologySetRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of <see cref="PipelineTopologySetRequest"/>. </summary>
        /// <param name="pipelineTopology">
        /// Pipeline topology describes the processing steps to be applied when processing media for a particular outcome. The topology should be defined according to the scenario to be achieved and can be reused across many pipeline instances which share the same processing characteristics. For instance, a pipeline topology which acquires data from a RTSP camera, process it with an specific AI model and stored the data on the cloud can be reused across many different cameras, as long as the same processing should be applied across all the cameras. Individual instance properties can be defined through the use of user-defined parameters, which allow for a topology to be parameterized, thus allowing individual pipelines to refer to different values, such as individual cameras RTSP endpoints and credentials. Overall a topology is composed of the following:
        ///
        ///   - Parameters: list of user defined parameters that can be references across the topology nodes.
        ///   - Sources: list of one or more data sources nodes such as an RTSP source which allows for media to be ingested from cameras.
        ///   - Processors: list of nodes which perform data analysis or transformations.
        ///   -Sinks: list of one or more data sinks which allow for data to be stored or exported to other destinations.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineTopology"/> is null. </exception>
        public PipelineTopologySetRequest(PipelineTopology pipelineTopology)
        {
            Argument.AssertNotNull(pipelineTopology, nameof(pipelineTopology));

            PipelineTopology = pipelineTopology;
            MethodName = "pipelineTopologySet";
        }

        /// <summary> Initializes a new instance of <see cref="PipelineTopologySetRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="pipelineTopology">
        /// Pipeline topology describes the processing steps to be applied when processing media for a particular outcome. The topology should be defined according to the scenario to be achieved and can be reused across many pipeline instances which share the same processing characteristics. For instance, a pipeline topology which acquires data from a RTSP camera, process it with an specific AI model and stored the data on the cloud can be reused across many different cameras, as long as the same processing should be applied across all the cameras. Individual instance properties can be defined through the use of user-defined parameters, which allow for a topology to be parameterized, thus allowing individual pipelines to refer to different values, such as individual cameras RTSP endpoints and credentials. Overall a topology is composed of the following:
        ///
        ///   - Parameters: list of user defined parameters that can be references across the topology nodes.
        ///   - Sources: list of one or more data sources nodes such as an RTSP source which allows for media to be ingested from cameras.
        ///   - Processors: list of nodes which perform data analysis or transformations.
        ///   -Sinks: list of one or more data sinks which allow for data to be stored or exported to other destinations.
        /// </param>
        internal PipelineTopologySetRequest(string methodName, string apiVersion, IDictionary<string, BinaryData> serializedAdditionalRawData, PipelineTopology pipelineTopology) : base(methodName, apiVersion, serializedAdditionalRawData)
        {
            PipelineTopology = pipelineTopology;
            MethodName = methodName ?? "pipelineTopologySet";
        }

        /// <summary> Initializes a new instance of <see cref="PipelineTopologySetRequest"/> for deserialization. </summary>
        internal PipelineTopologySetRequest()
        {
        }

        /// <summary>
        /// Pipeline topology describes the processing steps to be applied when processing media for a particular outcome. The topology should be defined according to the scenario to be achieved and can be reused across many pipeline instances which share the same processing characteristics. For instance, a pipeline topology which acquires data from a RTSP camera, process it with an specific AI model and stored the data on the cloud can be reused across many different cameras, as long as the same processing should be applied across all the cameras. Individual instance properties can be defined through the use of user-defined parameters, which allow for a topology to be parameterized, thus allowing individual pipelines to refer to different values, such as individual cameras RTSP endpoints and credentials. Overall a topology is composed of the following:
        ///
        ///   - Parameters: list of user defined parameters that can be references across the topology nodes.
        ///   - Sources: list of one or more data sources nodes such as an RTSP source which allows for media to be ingested from cameras.
        ///   - Processors: list of nodes which perform data analysis or transformations.
        ///   -Sinks: list of one or more data sinks which allow for data to be stored or exported to other destinations.
        /// </summary>
        public PipelineTopology PipelineTopology { get; set; }
    }
}
