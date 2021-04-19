// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using NUnit.Framework;

namespace Azure.Monitory.Query.Tests
{
    public class TypeBinderTests
    {
        [Test]
        public void CanDeserializeFromDictionary()
        {
            var model = new TestBinder().Deserialize<ModelClass>(new Dictionary<string, object>()
            {
                { "IntProperty", 1 },
                { "IntField", 2 },
                { "StringProperty", "1" },
                { "StringField", "2" },
            });

            Assert.AreEqual(1, model.IntProperty);
            Assert.AreEqual(2, model.IntField);
            Assert.AreEqual("1", model.StringProperty);
            Assert.AreEqual("2", model.StringField);
        }

        [Test]
        public void CanSerializeToDictionary()
        {
            var dictionary = new Dictionary<string, object>();

            new TestBinder().Serialize(new ModelClass()
            {
                IntProperty = 1,
                IntField = 2,
                StringProperty = "1",
                StringField = "2"
            }, dictionary);

            Assert.AreEqual(1, dictionary["IntProperty"]);
            Assert.AreEqual(2, dictionary["IntField"]);
            Assert.AreEqual(4, dictionary["IntReadOnlyProperty"]);
            Assert.AreEqual(5, dictionary["IntReadOnlyField"]);
            Assert.AreEqual("1", dictionary["StringProperty"]);
            Assert.AreEqual("2", dictionary["StringField"]);
            Assert.AreEqual("3", dictionary["StringReadOnlyProperty"]);
            Assert.AreEqual("42", dictionary["StringReadOnlyField"]);
        }

#pragma warning disable 414
#pragma warning disable 649
        private class ModelClass
        {
            public int IntProperty { get; set; }
            public int IntField;

            public int IntReadOnlyProperty { get; } = 4;
            public readonly int IntReadOnlyField = 5;

            public string StringProperty { get; set; }
            public string StringField;

            public string StringReadOnlyProperty { get; } = "3";
            public readonly string StringReadOnlyField = "42";
        }
#pragma warning restore 649
#pragma warning restore 414

        private class TestBinder : TypeBinder<IDictionary<string, object>>
        {
            protected override void Set<T>(IDictionary<string, object> destination, T value, BoundMemberInfo memberInfo)
            {
                destination[memberInfo.Name] = value;
            }

            protected override bool TryGet<T>(BoundMemberInfo memberInfo, IDictionary<string, object> source, out T value)
            {
                if (!source.TryGetValue(memberInfo.Name, out var objectValue))
                {
                    value = default;
                    return false;
                }

                if (typeof(T) == objectValue.GetType())
                {
                    value = (T) objectValue;
                    return true;
                }

                value = default;
                return false;
            }
        }
    }
}