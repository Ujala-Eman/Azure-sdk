// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Spring Cloud Config properties. </summary>
    public partial class SpringCloudConfigComponent : JavaComponentProperties
    {
        /// <summary> Initializes a new instance of <see cref="SpringCloudConfigComponent"/>. </summary>
        public SpringCloudConfigComponent()
        {
            ComponentType = JavaComponentType.SpringCloudConfig;
        }

        /// <summary> Initializes a new instance of <see cref="SpringCloudConfigComponent"/>. </summary>
        /// <param name="componentType"> Type of the Java Component. </param>
        /// <param name="provisioningState"> Provisioning state of the Java Component. </param>
        /// <param name="configurations"> List of Java Components configuration properties. </param>
        /// <param name="scale"> Java component scaling configurations. </param>
        /// <param name="serviceBinds"> List of Java Components that are bound to the Java component. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpringCloudConfigComponent(JavaComponentType componentType, JavaComponentProvisioningState? provisioningState, IList<JavaComponentConfigurationProperty> configurations, JavaComponentPropertiesScale scale, IList<JavaComponentServiceBind> serviceBinds, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(componentType, provisioningState, configurations, scale, serviceBinds, serializedAdditionalRawData)
        {
            ComponentType = componentType;
        }
    }
}
