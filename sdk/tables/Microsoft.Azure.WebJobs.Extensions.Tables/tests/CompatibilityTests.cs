// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

extern alias T1;

using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.Data.Tables;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Extensions.Tables.Tests
{
    public class CompatibilityTests: TablesLiveTestBase
    {
        private static DateTimeOffset DateTimeOffsetValue = DateTimeOffset.Parse("07-08-1997", null,  DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
        private static DateTime DateTimeValue = DateTime.Parse("07-08-1997", null,  DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);

        public CompatibilityTests(bool isAsync, bool useCosmos) : base(isAsync, useCosmos)
        {
        }

        [RecordedTest]
        [TestCaseSource(nameof(SdkExtensionPermutations))]
        public async Task CanSaveAndLoadITableEntityNullsAndDefaults(IWriter writer, IReader reader)
        {
            var testEntity = new TestITableEntity()
            {
                PartitionKey = PartitionKey,
                RowKey = RowKey
            };

            await writer.Write(this, testEntity);
            var output = await reader.Read<TestITableEntity>(this);

            AssertAreEqual(testEntity, output);
        }

        [RecordedTest]
        [TestCaseSource(nameof(T1T2ExtensionPermutations))]
        public async Task CanSaveAndLoadPoco(IWriter writer, IReader reader)
        {
            var testEntity = new TestEntity()
            {
                PartitionKey = PartitionKey,
                RowKey = RowKey
            };

            await writer.Write(this, testEntity);
            var output = await reader.Read<TestEntity>(this);

            AssertAreEqual(testEntity, output);
        }

        public static object[] SdkExtensionPermutations { get; } = {
            new object[] { Sdk.Instance, Extension.Instance },
            new object[] { Extension.Instance, Sdk.Instance },
            new object[] { Sdk.Instance, Sdk.Instance },
            new object[] { Extension.Instance, Extension.Instance }
        };

        public static object[] T1T2ExtensionPermutations { get; } = {
            new object[] { ExtensionT1.Instance, Extension.Instance },
            new object[] { Extension.Instance, ExtensionT1.Instance },
            new object[] { ExtensionT1.Instance, ExtensionT1.Instance },
            new object[] { Extension.Instance, Extension.Instance }
        };

        private void AssertAreEqual(object a, object b)
        {
            Assert.AreEqual(a.GetType(), b.GetType());
            foreach (var property in a.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.Name is nameof(ITableEntity.Timestamp) or nameof(ITableEntity.ETag)) continue;

                var av = property.GetValue(a);
                var bv = property.GetValue(b);
                Assert.AreEqual(av, bv, property.Name);
            }
        }

        public class TestITableEntity : ITableEntity
        {
            public TestITableEntity()
            {
                DatetimeOffsetTypeProperty = DateTimeOffsetValue;
                DatetimeTypeProperty = DateTimeValue;
            }

            public string StringTypeProperty { get; set; }
            public DateTime DatetimeTypeProperty { get; set; }
            public DateTimeOffset DatetimeOffsetTypeProperty { get; set; }
            public Guid GuidTypeProperty { get; set; }
            public byte[] BinaryTypeProperty { get; set; }
            public long Int64TypeProperty { get; set; }
            public ulong UInt64TypeProperty { get; set; }
            public double DoubleTypeProperty { get; set; }
            public int IntTypeProperty { get; set; }

            public DateTime? NullableDatetimeTypeProperty { get; set; }
            public DateTimeOffset? NullableDatetimeOffsetTypeProperty { get; set; }
            public Guid? NullableGuidTypeProperty { get; set; }
            public long? NullableInt64TypeProperty { get; set; }
            public ulong? NullableUInt64TypeProperty { get; set; }
            public double? NullableDoubleTypeProperty { get; set; }
            public int? NullableIntTypeProperty { get; set; }

            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
            public DateTimeOffset? Timestamp { get; set; }
            public ETag ETag { get; set; }
        }
        public class TestEntity
        {
            public TestEntity()
            {
                DatetimeOffsetTypeProperty = DateTimeOffsetValue;
                DatetimeTypeProperty = DateTimeValue;
            }

            public string StringTypeProperty { get; set; }
            public DateTime DatetimeTypeProperty { get; set; }
            public DateTimeOffset DatetimeOffsetTypeProperty { get; set; }
            public Guid GuidTypeProperty { get; set; }
            public byte[] BinaryTypeProperty { get; set; }
            public long Int64TypeProperty { get; set; }
            public ulong UInt64TypeProperty { get; set; }
            public double DoubleTypeProperty { get; set; }
            public int IntTypeProperty { get; set; }

            public DateTime? NullableDatetimeTypeProperty { get; set; }
            public DateTimeOffset? NullableDatetimeOffsetTypeProperty { get; set; }
            public Guid? NullableGuidTypeProperty { get; set; }
            public long? NullableInt64TypeProperty { get; set; }
            public ulong? NullableUInt64TypeProperty { get; set; }
            public double? NullableDoubleTypeProperty { get; set; }
            public int? NullableIntTypeProperty { get; set; }

            public string PartitionKey { get; set; }
            public string RowKey { get; set; }
            public DateTimeOffset Timestamp { get; set; }
            public string ETag { get; set; }
            public TestEntity NestedEntity { get; set; }
        }

        public interface IReader
        {
            ValueTask<T> Read<T>(CompatibilityTests test);
        }

        public interface IWriter
        {
            ValueTask Write<T>(CompatibilityTests test, T entity);
        }

        private class Sdk: IReader, IWriter
        {
            public static Sdk Instance = new();
            public async ValueTask<T> Read<T>(CompatibilityTests test)
            {
                return await (Task<Response<T>>)typeof(TableClient)
                    .GetMethod("GetEntityAsync", BindingFlags.Public | BindingFlags.Instance)
                    .MakeGenericMethod(typeof(T))
                    .Invoke(test.TableClient, new object[] { PartitionKey, RowKey, null, default(CancellationToken) });
            }

            public async ValueTask Write<T>(CompatibilityTests test, T entity)
            {
                await (Task)typeof(TableClient)
                    .GetMethod("AddEntityAsync", BindingFlags.Public | BindingFlags.Instance)
                    .MakeGenericMethod(typeof(T))
                    .Invoke(test.TableClient, new object[] { entity, default(CancellationToken) });
            }

            public override string ToString() => "SDK";
        }

        private class Extension : IReader, IWriter
        {
            public static Extension Instance = new();
            public async ValueTask<T> Read<T>(CompatibilityTests test)
            {
                var result = await test.CallAsync<GetEntityProgram<T>>();
                return result.Entity;
            }

            public async ValueTask Write<T>(CompatibilityTests test, T entity)
            {
                await test.CallAsync<AddEntityProgram<T>>(arguments: new { entity });
            }

            public override string ToString() => "Extension";

            private class AddEntityProgram<T>
            {
                [return: Table(TableNameExpression)]
                public T Call(T entity) => entity;
            }

            private class GetEntityProgram<T>
            {
                public void Call([Table(TableNameExpression, PartitionKey, RowKey)] T entity)
                {
                    Entity = entity;
                }

                public T Entity { get; set; }
            }
        }

        private class ExtensionT1 : IReader, IWriter
        {
            public static ExtensionT1 Instance = new();
            public async ValueTask<T> Read<T>(CompatibilityTests test)
            {
                var result = await test.CallAsync<GetEntityProgramT1<T>>(configure: builder => Configure(builder, test));
                return result.Entity;
            }

            public async ValueTask Write<T>(CompatibilityTests test,T entity)
            {
                await test.CallAsync<AddEntityProgramT1<T>>(arguments: new { entity }, configure: builder => Configure(builder, test));
            }

            private void Configure(HostBuilder builder, CompatibilityTests test)
            {
                test.DefaultConfigure(builder);
                builder.ConfigureWebJobs(jobsBuilder =>
                {
                    T1::Microsoft.Extensions.Hosting.StorageWebJobsBuilderExtensions.AddAzureStorage(jobsBuilder);
                });
            }

            public override string ToString() => "ExtensionT1";

            private class AddEntityProgramT1<T>
            {
                [return: T1::Microsoft.Azure.WebJobs.Table(TableNameExpression)]
                public T Call(T entity) => entity;
            }

            private class GetEntityProgramT1<T>
            {
                public void Call([T1::Microsoft.Azure.WebJobs.TableAttribute(TableNameExpression, PartitionKey, RowKey)] T entity)
                {
                    Entity = entity;
                }

                public T Entity { get; set; }
            }
        }
    }
}