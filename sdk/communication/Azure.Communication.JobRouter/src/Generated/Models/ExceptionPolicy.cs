// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A policy that defines actions to execute when exception are triggered. </summary>
    public partial class ExceptionPolicy
    {
        /// <summary> Initializes a new instance of ExceptionPolicy. </summary>
        public ExceptionPolicy()
        {
            ExceptionRules = new ChangeTrackingDictionary<string, ExceptionRule>();
        }

        /// <summary> Initializes a new instance of ExceptionPolicy. </summary>
        /// <param name="id"> The Id of the exception policy. </param>
        /// <param name="name"> (Optional) The name of the exception policy. </param>
        /// <param name="exceptionRules"> (Optional) A dictionary collection of exception rules on the exception policy. Key is the Id of each exception rule. </param>
        internal ExceptionPolicy(string id, string name, IDictionary<string, ExceptionRule> exceptionRules)
        {
            Id = id;
            Name = name;
            ExceptionRules = exceptionRules;
        }

        /// <summary> The Id of the exception policy. </summary>
        public string Id { get; }
        /// <summary> (Optional) The name of the exception policy. </summary>
        public string Name { get; set; }
    }
}
