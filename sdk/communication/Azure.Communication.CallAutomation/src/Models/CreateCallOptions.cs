﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// Options for the Create Call Request.
    /// </summary>
    public class CreateCallOptions: RepeatabilityHeaders
    {
        /// <summary>
        /// Creates a new CreateCallOptions object.
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="callSource"></param>
        /// <param name="callbackUri"></param>
        /// <param name="repeatabilityRequestId"></param>
        /// <param name="repeatabilityFirstSent"></param>
        public CreateCallOptions(CallSource callSource, IEnumerable<CommunicationIdentifier> targets, Uri callbackUri, Guid? repeatabilityRequestId = null, string repeatabilityFirstSent = default)
        {
            Targets = (IReadOnlyList<CommunicationIdentifier>)targets;
            CallSource = callSource;
            CallbackUri = callbackUri;
            RepeatabilityRequestId = repeatabilityRequestId;
            RepeatabilityFirstSent = repeatabilityFirstSent;
        }

        /// <summary>
        /// The targets of the call.
        /// </summary>
        public IReadOnlyList<CommunicationIdentifier> Targets { get; }

        /// <summary>
        /// The source of the call.
        /// </summary>
        public CallSource CallSource { get; }

        /// <summary>
        /// The callback Uri.
        /// </summary>
        public Uri CallbackUri { get; }

        /// <summary>
        /// The subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Media Streaming Configuration.
        /// </summary>
        public MediaStreamingOptions MediaStreamingOptions { get; set; }
    }
}
