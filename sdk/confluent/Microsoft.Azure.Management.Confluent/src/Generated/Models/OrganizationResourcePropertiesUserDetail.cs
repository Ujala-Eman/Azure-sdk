// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent.Models
{
    using System.Linq;

    /// <summary>
    /// Subscriber detail
    /// </summary>
    public partial class OrganizationResourcePropertiesUserDetail : UserDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationResourcePropertiesUserDetail class.
        /// </summary>
        public OrganizationResourcePropertiesUserDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationResourcePropertiesUserDetail class.
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="emailAddress">Email address</param>
        public OrganizationResourcePropertiesUserDetail(string firstName = default(string), string lastName = default(string), string emailAddress = default(string))
            : base(firstName, lastName, emailAddress)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
