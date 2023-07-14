// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The RecognizeOptions. </summary>
    internal partial class RecognizeOptionsInternal
    {
        /// <summary> Initializes a new instance of RecognizeOptionsInternal. </summary>
        /// <param name="targetParticipant"> Target participant of DTMF tone recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public RecognizeOptionsInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
            Choices = new ChangeTrackingList<RecognizeChoice>();
        }

        /// <summary> Determines if we interrupt the prompt and start recognizing. </summary>
        public bool? InterruptPrompt { get; set; }
        /// <summary> Time to wait for first input after prompt (if any). </summary>
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        /// <summary> Target participant of DTMF tone recognition. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Speech language to be recognized, If not set default is en-US. </summary>
        public string SpeechLanguage { get; set; }
        /// <summary> Endpoint where the custom model was deployed. </summary>
        public string SpeechRecognitionModelEndpointId { get; set; }
        /// <summary> Defines configurations for DTMF. </summary>
        public DtmfOptionsInternal DtmfOptions { get; set; }
        /// <summary> Defines Ivr choices for recognize. </summary>
        public IList<RecognizeChoice> Choices { get; }
        /// <summary> Defines continuous speech recognition option. </summary>
        public SpeechOptionsInternal SpeechOptions { get; set; }
    }
}
