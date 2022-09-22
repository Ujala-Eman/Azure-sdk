// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes the response from the external server. </summary>
    public partial class CodelessConnectorPollingResponseProperties
    {
        /// <summary> Initializes a new instance of CodelessConnectorPollingResponseProperties. </summary>
        /// <param name="eventsJsonPaths"> Describes the path we should extract the data in the response. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventsJsonPaths"/> is null. </exception>
        public CodelessConnectorPollingResponseProperties(IEnumerable<string> eventsJsonPaths)
        {
            if (eventsJsonPaths == null)
            {
                throw new ArgumentNullException(nameof(eventsJsonPaths));
            }

            EventsJsonPaths = eventsJsonPaths.ToList();
        }

        /// <summary> Initializes a new instance of CodelessConnectorPollingResponseProperties. </summary>
        /// <param name="eventsJsonPaths"> Describes the path we should extract the data in the response. </param>
        /// <param name="successStatusJsonPath"> Describes the path we should extract the status code in the response. </param>
        /// <param name="successStatusValue"> Describes the path we should extract the status value in the response. </param>
        /// <param name="isGzipCompressed"> Describes if the data in the response is Gzip. </param>
        internal CodelessConnectorPollingResponseProperties(IList<string> eventsJsonPaths, string successStatusJsonPath, string successStatusValue, bool? isGzipCompressed)
        {
            EventsJsonPaths = eventsJsonPaths;
            SuccessStatusJsonPath = successStatusJsonPath;
            SuccessStatusValue = successStatusValue;
            IsGzipCompressed = isGzipCompressed;
        }

        /// <summary> Describes the path we should extract the data in the response. </summary>
        public IList<string> EventsJsonPaths { get; }
        /// <summary> Describes the path we should extract the status code in the response. </summary>
        public string SuccessStatusJsonPath { get; set; }
        /// <summary> Describes the path we should extract the status value in the response. </summary>
        public string SuccessStatusValue { get; set; }
        /// <summary> Describes if the data in the response is Gzip. </summary>
        public bool? IsGzipCompressed { get; set; }
    }
}
