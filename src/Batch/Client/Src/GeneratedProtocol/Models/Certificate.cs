// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A certificate that can be installed on compute nodes and can be used
    /// to authenticate operations on the machine.
    /// </summary>
    public partial class Certificate
    {
        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        public Certificate() { }

        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        /// <param name="thumbprint">The X.509 thumbprint of the certificate.
        /// This is a sequence of up to 40 hex digits.</param>
        /// <param name="thumbprintAlgorithm">The algorithm used to derive the
        /// thumbprint.</param>
        /// <param name="url">The URL of the certificate.</param>
        /// <param name="state">The current state of the certificate.</param>
        /// <param name="stateTransitionTime">The time at which the
        /// certificate entered its current state.</param>
        /// <param name="previousState">The previous state of the
        /// certificate.</param>
        /// <param name="previousStateTransitionTime">The time at which the
        /// certificate entered its previous state.</param>
        /// <param name="publicData">The public part of the certificate as a
        /// base-64 encoded .cer file.</param>
        /// <param name="deleteCertificateError">The error that occurred on
        /// the last attempt to delete this certificate.</param>
        public Certificate(string thumbprint = default(string), string thumbprintAlgorithm = default(string), string url = default(string), CertificateState? state = default(CertificateState?), System.DateTime? stateTransitionTime = default(System.DateTime?), CertificateState? previousState = default(CertificateState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), string publicData = default(string), DeleteCertificateError deleteCertificateError = default(DeleteCertificateError))
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Url = url;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
        }

        /// <summary>
        /// Gets or sets the X.509 thumbprint of the certificate. This is a
        /// sequence of up to 40 hex digits.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the algorithm used to derive the thumbprint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the URL of the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the current state of the certificate.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'deleting', 'deletefailed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public CertificateState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the certificate entered its current
        /// state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the certificate.
        /// </summary>
        /// <remarks>
        /// This property is not set if the certificate is in its initial
        /// Active state. Possible values include: 'active', 'deleting',
        /// 'deletefailed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousState")]
        public CertificateState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the certificate entered its
        /// previous state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the certificate is in its initial
        /// Active state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the public part of the certificate as a base-64
        /// encoded .cer file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicData")]
        public string PublicData { get; set; }

        /// <summary>
        /// Gets or sets the error that occurred on the last attempt to delete
        /// this certificate.
        /// </summary>
        /// <remarks>
        /// This property is set only if the certificate is in the
        /// DeleteFailed state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deleteCertificateError")]
        public DeleteCertificateError DeleteCertificateError { get; set; }

    }
}
