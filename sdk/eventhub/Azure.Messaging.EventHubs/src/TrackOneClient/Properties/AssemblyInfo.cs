﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.CompilerServices;

#if CODESIGN
[assembly: InternalsVisibleTo("Azure.Messaging.EventHubs, PublicKey=0024000004800000940000000602000000240000525341310004000001000100097ad52abbeaa2e1a1982747cc0106534f65cfea6707eaed696a3a63daea80de2512746801a7e47f88e7781e71af960d89ba2e25561f70b0e2dbc93319e0af1961a719ccf5a4d28709b2b57a5d29b7c09dc8d269a490ebe2651c4b6e6738c27c5fb2c02469fe9757f0a3479ac310d6588a50a28d7dd431b907fd325e18b9e8ed")]
#else
[assembly: InternalsVisibleTo("Azure.Messaging.EventHubs)"]
#endif

