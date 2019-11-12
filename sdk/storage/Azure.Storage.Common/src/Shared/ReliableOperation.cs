﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;

#if CommonSDK
using Internals = Azure.Storage.Shared.Common;
namespace Azure.Storage.Shared.Common
#else
using Internals = Azure.Storage.Shared;
namespace Azure.Storage.Shared
#endif
{
    internal static class ReliableOperation
    {
        public static T Do<T>(Func<T> operation, Action reset, Action cleanup, Func<Exception, bool> predicate, int maximumRetries)
        {
            while (true)
            {
                try
                {
                    T result = operation();
                    return result;
                }
                catch (OperationCanceledException)
                {
                    cleanup();
                    throw;
                }
                catch (Exception e) when (predicate(e))
                {
                    if (maximumRetries-- <= 0)
                    {
                        cleanup();
                        throw;
                    }

                    reset();
                }
                catch
                {
                    cleanup();
                    throw;
                }
            }
        }

        public static ValueTask<T> DoAsync<T>(Func<ValueTask<T>> operation, Internals.ReliabilityConfiguration? reliabilityConfiguration = default, int maximumRetries = Internals.Constants.MaxReliabilityRetries)
        {
            reliabilityConfiguration ??= Internals.ReliabilityConfiguration.Default;

            return DoAsync(operation, reliabilityConfiguration.Value.Reset, reliabilityConfiguration.Value.Cleanup, reliabilityConfiguration.Value.ExceptionPredicate, maximumRetries);
        }

        public static async ValueTask<T> DoAsync<T>(Func<ValueTask<T>> operation, Action reset, Action cleanup, Func<Exception, bool> predicate, int maximumRetries)
        {
            while (true)
            {
                try
                {
                    T result = await operation().ConfigureAwait(false);
                    return result;
                }
                catch (OperationCanceledException)
                {
                    cleanup();
                    throw;
                }
                catch (Exception e) when (predicate(e))
                {
                    if (maximumRetries-- <= 0)
                    {
                        cleanup();
                        throw;
                    }

                    reset();
                }
                catch
                {
                    cleanup();
                    throw;
                }
            }
        }

        public static async ValueTask<T> DoSyncOrAsync<T>(bool isAsync, Func<ValueTask<T>> operation, Action reset, Action cleanup, Func<Exception, bool> predicate, int maximumRetries)
        {
            while (true)
            {
                try
                {
                    T result = isAsync ?
                        await operation().ConfigureAwait(false) :
                        operation().EnsureCompleted();
                    return result;
                }
                catch (OperationCanceledException)
                {
                    cleanup();
                    throw;
                }
                catch (Exception e) when (predicate(e))
                {
                    if (maximumRetries-- <= 0)
                    {
                        cleanup();
                        throw;
                    }

                    reset();
                }
                catch
                {
                    cleanup();
                    throw;
                }
            }
        }
    }
}
