﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core.Cryptography
{
    /// <summary>
    /// A key which is used to encrypt, or wrap, another key
    /// </summary>
    public interface IKeyEncryptionKey
    {
        /// <summary>
        /// Encrypts the specified key using the specified algorithm
        /// </summary>
        /// <param name="algorithm">The key wrap algorithm used to encrypt the specified key</param>
        /// <param name="key">The key to be encrypted</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The encrypted key bytes</returns>
        byte[] WrapKey(string algorithm, byte[] key, CancellationToken cancellationToken);

        /// <summary>
        /// Encrypts the specified key using the specified algorithm
        /// </summary>
        /// <param name="algorithm">The key wrap algorithm used to encrypt the specified key</param>
        /// <param name="key">The key to be encrypted</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The encrypted key bytes</returns>
        Task<byte[]> WrapKeyAsync(string algorithm, byte[] key, CancellationToken cancellationToken);

        /// <summary>
        /// Decrypts the specified encrpted key using the specified algorithm
        /// </summary>
        /// <param name="algorithm">The key wrap algorithm which was used to encrypt the specified encrypted key</param>
        /// <param name="encryptedKey">The encrypted key to be decrypted</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The decrpted key bytes</returns>
        byte[] UnwrapKey(string algorithm, byte[] encryptedKey, CancellationToken cancellationToken);

        /// <summary>
        /// Decrypts the specified encrpted key using the specified algorithm
        /// </summary>
        /// <param name="algorithm">The key wrap algorithm which was used to encrypt the specified encrypted key</param>
        /// <param name="encryptedKey">The encrypted key to be decrypted</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The decrpted key bytes</returns>
        Task<byte[]> UnwrapKeyAsync(string algorithm, byte[] encryptedKey, CancellationToken cancellationToken);
    }
}
