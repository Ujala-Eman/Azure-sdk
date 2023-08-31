// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerAutomaticTuning data model.
    /// Server-level Automatic Tuning.
    /// </summary>
    public partial class SqlServerAutomaticTuningData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerAutomaticTuningData"/>. </summary>
        public SqlServerAutomaticTuningData()
        {
            Options = new ChangeTrackingDictionary<string, AutomaticTuningServerOptions>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerAutomaticTuningData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="desiredState"> Automatic tuning desired state. </param>
        /// <param name="actualState"> Automatic tuning actual state. </param>
        /// <param name="options"> Automatic tuning options definition. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerAutomaticTuningData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AutomaticTuningServerMode? desiredState, AutomaticTuningServerMode? actualState, IDictionary<string, AutomaticTuningServerOptions> options, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DesiredState = desiredState;
            ActualState = actualState;
            Options = options;
            _rawData = rawData;
        }

        /// <summary> Automatic tuning desired state. </summary>
        public AutomaticTuningServerMode? DesiredState { get; set; }
        /// <summary> Automatic tuning actual state. </summary>
        public AutomaticTuningServerMode? ActualState { get; }
        /// <summary> Automatic tuning options definition. </summary>
        public IDictionary<string, AutomaticTuningServerOptions> Options { get; }
    }
}
