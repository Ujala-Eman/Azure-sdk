// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A collection of workflow run action repetitions. </summary>
    internal partial class LogicWorkflowRunActionRepetitionDefinitionList
    {
        /// <summary> Initializes a new instance of LogicWorkflowRunActionRepetitionDefinitionList. </summary>
        internal LogicWorkflowRunActionRepetitionDefinitionList()
        {
            Value = new ChangeTrackingList<LogicWorkflowRunActionRepetitionDefinitionData>();
        }

        /// <summary> Initializes a new instance of LogicWorkflowRunActionRepetitionDefinitionList. </summary>
        /// <param name="nextLink"> The link used to get the next page of recommendations. </param>
        /// <param name="value"></param>
        internal LogicWorkflowRunActionRepetitionDefinitionList(string nextLink, IReadOnlyList<LogicWorkflowRunActionRepetitionDefinitionData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of recommendations. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<LogicWorkflowRunActionRepetitionDefinitionData> Value { get; }
    }
}
