// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a encoded task step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("EncodedTask")]
    public partial class EncodedTaskStep : TaskStepProperties
    {
        /// <summary>
        /// Initializes a new instance of the EncodedTaskStep class.
        /// </summary>
        public EncodedTaskStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncodedTaskStep class.
        /// </summary>
        /// <param name="encodedTaskContent">Base64 encoded value of the
        /// template/definition file content.</param>
        /// <param name="baseImageDependencies">List of base image dependencies
        /// for a step.</param>
        /// <param name="contextPath">The URL(absolute or relative) of the
        /// source context for the task step.</param>
        /// <param name="encodedValuesContent">Base64 encoded value of the
        /// parameters/values file content.</param>
        /// <param name="values">The collection of overridable values that can
        /// be passed when running a task.</param>
        public EncodedTaskStep(string encodedTaskContent, IList<BaseImageDependency> baseImageDependencies = default(IList<BaseImageDependency>), string contextPath = default(string), string encodedValuesContent = default(string), IList<SetValue> values = default(IList<SetValue>))
            : base(baseImageDependencies, contextPath)
        {
            EncodedTaskContent = encodedTaskContent;
            EncodedValuesContent = encodedValuesContent;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base64 encoded value of the template/definition file
        /// content.
        /// </summary>
        [JsonProperty(PropertyName = "encodedTaskContent")]
        public string EncodedTaskContent { get; set; }

        /// <summary>
        /// Gets or sets base64 encoded value of the parameters/values file
        /// content.
        /// </summary>
        [JsonProperty(PropertyName = "encodedValuesContent")]
        public string EncodedValuesContent { get; set; }

        /// <summary>
        /// Gets or sets the collection of overridable values that can be
        /// passed when running a task.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<SetValue> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncodedTaskContent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EncodedTaskContent");
            }
            if (Values != null)
            {
                foreach (var element in Values)
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
