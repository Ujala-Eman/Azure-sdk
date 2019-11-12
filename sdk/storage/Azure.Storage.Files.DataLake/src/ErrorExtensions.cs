﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using Azure.Storage.Shared;
using Internals = Azure.Storage.Shared;

namespace Azure.Storage.Files.DataLake
{
    internal static class ErrorExtensions
    {
        internal static Exception CreateException(this string jsonMessage, Response response)
        {
            if (string.IsNullOrWhiteSpace(jsonMessage))
            {
                return new RequestFailedException(
                    status: response.Status,
                    errorCode: response.Status.ToString(CultureInfo.InvariantCulture),
                    message: response.ReasonPhrase,
                    innerException: new Exception());
            }
            else
            {
                Dictionary<string, Dictionary<string, string>> errorDictionary
                    = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonMessage);
                return new RequestFailedException(
                    status: response.Status,
                    errorCode: errorDictionary[Internals.Constants.DataLake.ErrorKey][Internals.Constants.DataLake.ErrorCodeKey],
                    message: errorDictionary[Internals.Constants.DataLake.ErrorKey][Internals.Constants.DataLake.ErrorMessageKey],
                    innerException: new Exception());
            }
        }

    }
}
