﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Azure.Core
{
    /// <summary>
    /// Argument validation.
    /// </summary>
    /// <remarks>
    ///   <para>This class should be shared via source using Azure.Core.props and contain only common argument validation.
    ///     It is declared partial so that you can use the same familiar class name but extend it with project-specific validation.
    ///     To extend the functionality of this class, just declare your own partial <see cref="Argument"/> class with project-specific methods.
    ///   </para>
    ///   <para>
    ///     Be sure to document exceptions thrown by these methods on your public methods.
    ///   </para>
    /// </remarks>
    internal static partial class Argument
    {
        // TODO: Add nullability attributes as needed when possible.

        /// <summary>
        /// Throws if <paramref name="value"/> is null.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        public static void NotNull<T>(T value, string name) where T : class
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> has not been initialized.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> has not been initialized.</exception>
        public static void NotNull<T>(T? value, string name) where T : struct
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> is null or an empty collection.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> is an empty collection.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        public static void NotNullOrEmpty<T>(IEnumerable<T> value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }

            // .NET Framework's Enumerable.Any() always allocates an enumerator, so we optimize for collections here.
            if (value is ICollection<T> collectionOfT && collectionOfT.Count == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }

            if (value is ICollection collection && collection.Count == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }

            using IEnumerator<T> e = value.GetEnumerator();
            if (!e.MoveNext())
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> is null or an empty string.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> is an empty string.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        public static void NotNullOrEmpty(string value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }

            if (value.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> is null, an empty string, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> is an empty string or consists only of white-space characters.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        public static void NotNullOrWhiteSpace(string value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Value cannot be empty or contain only white-space characters.", name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> is the default value for type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of structure to validate which implements <see cref="IEquatable{T}"/>.</typeparam>
        /// <param name="value">The value to validate.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> is the default value for type <typeparamref name="T"/>.</exception>
        public static void NotDefault<T>(ref T value, string name) where T : struct, IEquatable<T>
        {
            if (value.Equals(default))
            {
                throw new ArgumentException("Value cannot be empty.", name);
            }
        }

        /// <summary>
        /// Throws if <paramref name="value"/> is less than the <paramref name="minimum"/> or greater than the <paramref name="maximum"/>.
        /// </summary>
        /// <typeparam name="T">The type of to validate which implements <see cref="IComparable{T}"/>.</typeparam>
        /// <param name="value">The value to validate.</param>
        /// <param name="minimum">The minimum value to compare.</param>
        /// <param name="maximum">The maximum value to compare.</param>
        /// <param name="name">The name of the parameter.</param>
        public static void InRange<T>(T value, T minimum, T maximum, string name) where T : struct, IComparable<T>
        {
            if (minimum.CompareTo(value) > 0)
            {
                throw new ArgumentOutOfRangeException(name, "Value is less than the minimum allowed.");
            }

            if (maximum.CompareTo(value) < 0)
            {
                throw new ArgumentOutOfRangeException(name, "Value is greater than the maximum allowed.");
            }
        }
    }
}
