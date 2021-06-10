﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.DigitalTwins.Core.QueryBuilder;
using Azure.DigitalTwins.Core.Queries.QueryBuilders;
using FluentAssertions;
using NUnit.Framework;

namespace Azure.DigitalTwins.Core.Tests.QueryBuilderTests
{
    public class AdtQueryBuilderTests
    {
        [Test]
        public void AdtQueryBuilder_Select_AllSimple()
        {
            new AdtQueryBuilder()
                .Select("*")
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT * FROM DigitalTwins");
        }

        [Test]
        public void AdtQueryBuilder_Select_SingleProperty()
        {
            new AdtQueryBuilder()
                .Select("Room")
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT Room FROM DigitalTwins");
    }

        [Test]
        public void AdtQueryBuilder_Select_MultipleProperties()
        {
            new AdtQueryBuilder()
                .Select("Room", "Factory", "Temperature", "Humidity")
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT Room, Factory, Temperature, Humidity FROM DigitalTwins");
        }

        [Test]
        public void AdtQueryBuilder_Select_Aggregates_Top_All()
        {
            new AdtQueryBuilder()
                .SelectTop(5)
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT TOP(5) FROM DigitalTwins");
        }

        [Test]
        public void AdtQueryBuilder_Select_Aggregates_Top_Properties()
        {
            new AdtQueryBuilder()
                .SelectTop(3, "Temperature", "Humidity")
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT TOP(3) Temperature, Humidity FROM DigitalTwins");
        }

        public void AdtQueryBuilder_Select_Aggregates_Count()
        {
            new AdtQueryBuilder()
                .SelectCount()
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT COUNT() FROM DigitalTwins");
        }

        [Test]
        public void AdtQueryBuilder_Select_Override()
        {
            new AdtQueryBuilder()
                .SelectOverride("TOP(3) Room, Temperature")
                .From(AdtCollection.DigitalTwins)
                .Build()
                .Stringify()
                .Should()
                .Be("SELECT TOP(3) Room, Temperature FROM DigitalTwins");
        }
    }
}
