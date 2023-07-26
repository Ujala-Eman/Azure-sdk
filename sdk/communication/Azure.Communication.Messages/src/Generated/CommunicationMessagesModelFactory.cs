// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Messages;

namespace Azure.Communication.Messages.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class CommunicationMessagesModelFactory
    {
        /// <summary> Initializes a new instance of SendMessageResult. </summary>
        /// <param name="receipts"> Receipts of the send message operation. </param>
        /// <returns> A new <see cref="Messages.SendMessageResult"/> instance for mocking. </returns>
        public static SendMessageResult SendMessageResult(IEnumerable<MessageReceipt> receipts = null)
        {
            receipts ??= new List<MessageReceipt>();

            return new SendMessageResult(receipts?.ToList());
        }

        /// <summary> Initializes a new instance of MessageReceipt. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="to"> The native external platform user identifier of the recipient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> or <paramref name="to"/> is null. </exception>
        /// <returns> A new <see cref="Messages.MessageReceipt"/> instance for mocking. </returns>
        public static MessageReceipt MessageReceipt(string messageId = null, string to = null)
        {
            if (messageId == null)
            {
                throw new ArgumentNullException(nameof(messageId));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            return new MessageReceipt(messageId, to);
        }
    }
}
