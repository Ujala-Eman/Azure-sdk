// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Settings which specify how to run a multi-instance task.
    /// </summary>
    /// <remarks>
    /// Multi-instance tasks are commonly used to support MPI tasks.
    /// </remarks>
    public partial class MultiInstanceSettings
    {
        /// <summary>
        /// Initializes a new instance of the MultiInstanceSettings class.
        /// </summary>
        public MultiInstanceSettings() { }

        /// <summary>
        /// Initializes a new instance of the MultiInstanceSettings class.
        /// </summary>
        /// <param name="numberOfInstances">The number of compute nodes
        /// required by the task.</param>
        /// <param name="coordinationCommandLine">The command line to run on
        /// all the compute nodes to enable them to coordinate when the primary
        /// runs the main task command.</param>
        /// <param name="commonResourceFiles">A list of files that the Batch
        /// service will download before running the coordination command
        /// line.</param>
        public MultiInstanceSettings(int numberOfInstances, string coordinationCommandLine = default(string), System.Collections.Generic.IList<ResourceFile> commonResourceFiles = default(System.Collections.Generic.IList<ResourceFile>))
        {
            this.NumberOfInstances = numberOfInstances;
            this.CoordinationCommandLine = coordinationCommandLine;
            this.CommonResourceFiles = commonResourceFiles;
        }

        /// <summary>
        /// Gets or sets the number of compute nodes required by the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfInstances")]
        public int NumberOfInstances { get; set; }

        /// <summary>
        /// Gets or sets the command line to run on all the compute nodes to
        /// enable them to coordinate when the primary runs the main task
        /// command.
        /// </summary>
        /// <remarks>
        /// A typical coordination command line launches a background service
        /// and verifies that the service is ready to process inter-node
        /// messages.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "coordinationCommandLine")]
        public string CoordinationCommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// before running the coordination command line.
        /// </summary>
        /// <remarks>
        /// The difference between common resource files and task resource
        /// files is that common resource files are downloaded for all subtasks
        /// including the primary, whereas task resource files are downloaded
        /// only for the primary.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commonResourceFiles")]
        public System.Collections.Generic.IList<ResourceFile> CommonResourceFiles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.CommonResourceFiles != null)
            {
                foreach (var element in this.CommonResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
