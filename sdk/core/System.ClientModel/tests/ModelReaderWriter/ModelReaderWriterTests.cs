﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;
using System.ClientModel.Primitives;
using System.ClientModel.Tests.Client.ModelReaderWriterTests.Models;
using System.Text.Json;

namespace System.ClientModel.Tests.ModelReaderWriterTests
{
    public class ModelReaderWriterTests
    {
        [Test]
        public void ArgumentExceptions()
        {
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read<BaseWithNoUnknown>(null!));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read(null!, typeof(BaseWithNoUnknown)));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read(new BinaryData(new byte[] { }), null!));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Write<BaseWithNoUnknown>(null!));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Write(null!));

            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read<BaseWithNoUnknown>(null!, ModelReaderWriterOptions.Wire));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read(null!, typeof(BaseWithNoUnknown), ModelReaderWriterOptions.Wire));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Read(new BinaryData(new byte[] { }), null!, ModelReaderWriterOptions.Wire));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Write<BaseWithNoUnknown>(null!, ModelReaderWriterOptions.Wire));
            Assert.Throws<ArgumentNullException>(() => ModelReaderWriter.Write(null!, ModelReaderWriterOptions.Wire));
        }

        [TestCaseSource(typeof(ReaderWriterTestSource), "InvalidOperationBinaryData")]
        public void ValidateInvalidOperationBinaryData(BinaryData data)
        {
            Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Read<ModelX>(data));
            Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Read(data, typeof(ModelX)));
        }

        [TestCaseSource(typeof(ReaderWriterTestSource), "JsonExceptionBinaryData")]
        public void ValidateJsonExceptionBinaryData(BinaryData data)
        {
            bool gotException = false;
            try
            {
                ModelX? x = ModelReaderWriter.Read<ModelX>(data);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType().IsSubclassOf(typeof(JsonException)), $"Expected a subclass of {nameof(JsonException)} but got {ex.GetType().Name}");
                gotException = true;
            }

            Assert.IsTrue(gotException, "Did not recieve exception");

            gotException = false;
            try
            {
                object? x = ModelReaderWriter.Read(data, typeof(ModelX));
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType().IsSubclassOf(typeof(JsonException)), $"Expected a subclass of {nameof(JsonException)} but got {ex.GetType().Name}");
                gotException = true;
            }

            Assert.IsTrue(gotException, "Did not recieve exception");
        }

        [TestCaseSource(typeof(ReaderWriterTestSource), "NullBinaryData")]
        public void ValidateNullBinaryData(BinaryData data)
        {
            Assert.IsNull(ModelReaderWriter.Read<ModelX>(data));
            Assert.IsNull(ModelReaderWriter.Read(data, typeof(ModelX)));
        }

        [TestCaseSource(typeof(ReaderWriterTestSource), "EmptyObjectBinaryData")]
        public void ValidateEmptyObjectBinaryData(BinaryData data)
        {
            ModelX? x = ModelReaderWriter.Read<ModelX>(data);
            Assert.IsNotNull(x);
            Assert.IsNull(x!.Kind);

            object? obj = ModelReaderWriter.Read(data, typeof(ModelX));
            Assert.IsNotNull(obj);
            Assert.IsNull(((ModelX)obj!).Kind);
        }

        [Test]
        public void ValidateErrorIfUnknownDoesntExist()
        {
            BaseWithNoUnknown baseInstance = new SubType();
            Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Read<BaseWithNoUnknown>(new BinaryData(Array.Empty<byte>())));
            Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Read(new BinaryData(Array.Empty<byte>()), typeof(BaseWithNoUnknown)));
        }

        [Test]
        public void ValidateErrorIfNoDefaultCtor()
        {
            Assert.Throws<MissingMethodException>(() => ModelReaderWriter.Read<ModelWithNoDefaultCtor>(new BinaryData(Array.Empty<byte>())));
        }

        [Test]
        public void ValidateErrorIfNotImplementInterface()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Read(new BinaryData(Array.Empty<byte>()), typeof(DoesntImplementInterface)));
            Assert.IsTrue(ex?.Message.Contains("does not implement"));
            ex = Assert.Throws<InvalidOperationException>(() => ModelReaderWriter.Write(new DoesntImplementInterface()));
            Assert.IsTrue(ex?.Message.Contains("does not implement"));
        }

        private class DoesntImplementInterface { }

        private class SubType : BaseWithNoUnknown, IJsonModel<SubType>
        {
            string IModel<SubType>.GetWireFormat(ModelReaderWriterOptions options) => "J";

            SubType IJsonModel<SubType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
            {
                return new SubType();
            }

            SubType IModel<SubType>.Create(BinaryData data, ModelReaderWriterOptions options)
            {
                return new SubType();
            }

            void IJsonModel<SubType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
            {
                return;
            }

            BinaryData IModel<SubType>.Write(ModelReaderWriterOptions options)
            {
                return new BinaryData(Array.Empty<byte>());
            }
        }

        private abstract class BaseWithNoUnknown : IJsonModel<BaseWithNoUnknown>
        {
            string IModel<BaseWithNoUnknown>.GetWireFormat(ModelReaderWriterOptions options) => "J";

            BaseWithNoUnknown IJsonModel<BaseWithNoUnknown>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
            {
                return new SubType();
            }

            BaseWithNoUnknown IModel<BaseWithNoUnknown>.Create(BinaryData data, ModelReaderWriterOptions options)
            {
                return new SubType();
            }

            void IJsonModel<BaseWithNoUnknown>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
            {
                return;
            }

            BinaryData IModel<BaseWithNoUnknown>.Write(ModelReaderWriterOptions options)
            {
                return new BinaryData(Array.Empty<byte>());
            }
        }

        private class ModelWithNoDefaultCtor : IJsonModel<ModelWithNoDefaultCtor>
        {
            public ModelWithNoDefaultCtor(int x) { }

            string IModel<ModelWithNoDefaultCtor>.GetWireFormat(ModelReaderWriterOptions options) => "J";

            ModelWithNoDefaultCtor IJsonModel<ModelWithNoDefaultCtor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
            {
                return new ModelWithNoDefaultCtor(1);
            }

            ModelWithNoDefaultCtor IModel<ModelWithNoDefaultCtor>.Create(BinaryData data, ModelReaderWriterOptions options)
            {
                return new ModelWithNoDefaultCtor(1);
            }

            void IJsonModel<ModelWithNoDefaultCtor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
            {
                return;
            }

            BinaryData IModel<ModelWithNoDefaultCtor>.Write(ModelReaderWriterOptions options)
            {
                return new BinaryData(Array.Empty<byte>());
            }
        }
    }
}
