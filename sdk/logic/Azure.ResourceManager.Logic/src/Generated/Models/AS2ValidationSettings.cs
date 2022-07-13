// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The AS2 agreement validation settings. </summary>
    public partial class AS2ValidationSettings
    {
        /// <summary> Initializes a new instance of AS2ValidationSettings. </summary>
        /// <param name="overrideMessageProperties"> The value indicating whether to override incoming message properties with those in agreement. </param>
        /// <param name="encryptMessage"> The value indicating whether the message has to be encrypted. </param>
        /// <param name="signMessage"> The value indicating whether the message has to be signed. </param>
        /// <param name="compressMessage"> The value indicating whether the message has to be compressed. </param>
        /// <param name="checkDuplicateMessage"> The value indicating whether to check for duplicate message. </param>
        /// <param name="interchangeDuplicatesValidityDays"> The number of days to look back for duplicate interchange. </param>
        /// <param name="checkCertificateRevocationListOnSend"> The value indicating whether to check for certificate revocation list on send. </param>
        /// <param name="checkCertificateRevocationListOnReceive"> The value indicating whether to check for certificate revocation list on receive. </param>
        /// <param name="encryptionAlgorithm"> The encryption algorithm. </param>
        public AS2ValidationSettings(bool overrideMessageProperties, bool encryptMessage, bool signMessage, bool compressMessage, bool checkDuplicateMessage, int interchangeDuplicatesValidityDays, bool checkCertificateRevocationListOnSend, bool checkCertificateRevocationListOnReceive, EncryptionAlgorithm encryptionAlgorithm)
        {
            OverrideMessageProperties = overrideMessageProperties;
            EncryptMessage = encryptMessage;
            SignMessage = signMessage;
            CompressMessage = compressMessage;
            CheckDuplicateMessage = checkDuplicateMessage;
            InterchangeDuplicatesValidityDays = interchangeDuplicatesValidityDays;
            CheckCertificateRevocationListOnSend = checkCertificateRevocationListOnSend;
            CheckCertificateRevocationListOnReceive = checkCertificateRevocationListOnReceive;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary> Initializes a new instance of AS2ValidationSettings. </summary>
        /// <param name="overrideMessageProperties"> The value indicating whether to override incoming message properties with those in agreement. </param>
        /// <param name="encryptMessage"> The value indicating whether the message has to be encrypted. </param>
        /// <param name="signMessage"> The value indicating whether the message has to be signed. </param>
        /// <param name="compressMessage"> The value indicating whether the message has to be compressed. </param>
        /// <param name="checkDuplicateMessage"> The value indicating whether to check for duplicate message. </param>
        /// <param name="interchangeDuplicatesValidityDays"> The number of days to look back for duplicate interchange. </param>
        /// <param name="checkCertificateRevocationListOnSend"> The value indicating whether to check for certificate revocation list on send. </param>
        /// <param name="checkCertificateRevocationListOnReceive"> The value indicating whether to check for certificate revocation list on receive. </param>
        /// <param name="encryptionAlgorithm"> The encryption algorithm. </param>
        /// <param name="signingAlgorithm"> The signing algorithm. </param>
        internal AS2ValidationSettings(bool overrideMessageProperties, bool encryptMessage, bool signMessage, bool compressMessage, bool checkDuplicateMessage, int interchangeDuplicatesValidityDays, bool checkCertificateRevocationListOnSend, bool checkCertificateRevocationListOnReceive, EncryptionAlgorithm encryptionAlgorithm, SigningAlgorithm? signingAlgorithm)
        {
            OverrideMessageProperties = overrideMessageProperties;
            EncryptMessage = encryptMessage;
            SignMessage = signMessage;
            CompressMessage = compressMessage;
            CheckDuplicateMessage = checkDuplicateMessage;
            InterchangeDuplicatesValidityDays = interchangeDuplicatesValidityDays;
            CheckCertificateRevocationListOnSend = checkCertificateRevocationListOnSend;
            CheckCertificateRevocationListOnReceive = checkCertificateRevocationListOnReceive;
            EncryptionAlgorithm = encryptionAlgorithm;
            SigningAlgorithm = signingAlgorithm;
        }

        /// <summary> The value indicating whether to override incoming message properties with those in agreement. </summary>
        public bool OverrideMessageProperties { get; set; }
        /// <summary> The value indicating whether the message has to be encrypted. </summary>
        public bool EncryptMessage { get; set; }
        /// <summary> The value indicating whether the message has to be signed. </summary>
        public bool SignMessage { get; set; }
        /// <summary> The value indicating whether the message has to be compressed. </summary>
        public bool CompressMessage { get; set; }
        /// <summary> The value indicating whether to check for duplicate message. </summary>
        public bool CheckDuplicateMessage { get; set; }
        /// <summary> The number of days to look back for duplicate interchange. </summary>
        public int InterchangeDuplicatesValidityDays { get; set; }
        /// <summary> The value indicating whether to check for certificate revocation list on send. </summary>
        public bool CheckCertificateRevocationListOnSend { get; set; }
        /// <summary> The value indicating whether to check for certificate revocation list on receive. </summary>
        public bool CheckCertificateRevocationListOnReceive { get; set; }
        /// <summary> The encryption algorithm. </summary>
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }
        /// <summary> The signing algorithm. </summary>
        public SigningAlgorithm? SigningAlgorithm { get; set; }
    }
}
