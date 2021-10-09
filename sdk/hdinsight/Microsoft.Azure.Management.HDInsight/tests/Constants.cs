﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Management.HDInsight.Tests
{
    public static class Constants
    {
        public static class StorageConfigurations
        {
            public const string DefaultFsKey = "fs.defaultFS";
            public const string WasbStorageAccountKeyFormat = "fs.azure.account.key.{0}";
            public const string AdlHostNameKey = "dfs.adls.home.hostname";
            public const string AdlMountPointKey = "dfs.adls.home.mountpoint";

            public const string DefaultFsWasbValueFormat = "wasb://{0}@{1}";
            public const string DefaultFsAdlValue = "adl://home";
        }

        public static class MetastoreConfigurations
        {
            public const string ConnectionUrlFormat =
                "jdbc:sqlserver://{0};database={1};encrypt=true;trustServerCertificate=true;create=false;loginTimeout=300;sendStringParametersAsUnicode=true;prepareSQL=0";

            public const string DatabaseValue = "Existing MSSQL Server database with SQL authentication";
            public const string DatabaseTypeValue = "mssql";

            public static class HiveSite
            {
                public const string ConnectionUrlKey = "javax.jdo.option.ConnectionURL";
                public const string ConnectionUserNameKey = "javax.jdo.option.ConnectionUserName";
                public const string ConnectionPasswordKey = "javax.jdo.option.ConnectionPassword";
                public const string ConnectionDriverNameKey = "javax.jdo.option.ConnectionDriverName";

                public const string ConnectionDriverNameValue = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
            }

            public static class HiveEnv
            {
                public const string DatabaseKey = "hive_database";
                public const string DatabaseNameKey = "hive_database_name";
                public const string DatabaseTypeKey = "hive_database_type";
                public const string ExistingDatabaseKey = "hive_existing_mssql_server_database";
                public const string ExistingHostKey = "hive_existing_mssql_server_host";
                public const string HostNameKey = "hive_hostname";
            }

            public static class OozieSite
            {
                public const string UrlKey = "oozie.service.JPAService.jdbc.url";
                public const string UserNameKey = "oozie.service.JPAService.jdbc.username";
                public const string PasswordKey = "oozie.service.JPAService.jdbc.password";
                public const string DriverKey = "oozie.service.JPAService.jdbc.driver";
                public const string SchemaKey = "oozie.db.schema.name";

                public const string DriverValue = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
                public const string SchemaValue = "oozie";
            }

            public static class OozieEnv
            {
                public const string DatabaseKey = "oozie_database";
                public const string DatabaseNameKey = "oozie_database_name";
                public const string DatabaseTypeKey = "oozie_database_type";
                public const string ExistingDatabaseKey = "oozie_existing_mssql_server_database";
                public const string ExistingHostKey = "oozie_existing_mssql_server_host";
                public const string HostNameKey = "oozie_hostname";
            }

            public static class AmbariConfiguration
            {
                public const string SqlServerKey = "database-server";
                public const string DatabaseNameKey = "database-name";
                public const string DatabaseUserKey = "database-user-name";
                public const string DatabasePasswordKey = "database-user-password";
            }
        }

        public static class ConfigurationKey
        {
            /// <summary>
            /// The constant for Hive site configs.
            /// </summary>
            public const string HiveSite = "hive-site";

            /// <summary>
            /// The constant for hive environment configs.
            /// </summary>
            public const string HiveEnv = "hive-env";

            /// <summary>
            /// The constant for Oozie site configs.
            /// </summary>
            public const string OozieSite = "oozie-site";

            /// <summary>
            /// The constant for Oozie environment configs.
            /// </summary>
            public const string OozieEnv = "oozie-env";

            /// <summary>
            /// The constant for ambari environment configs.
            /// </summary>
            public const string AmbariConf = "ambari-conf";
        }
    }
}
