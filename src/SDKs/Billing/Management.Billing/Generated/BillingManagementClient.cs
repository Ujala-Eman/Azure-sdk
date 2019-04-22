// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Billing client provides access to billing resources for Azure
    /// subscriptions.
    /// </summary>
    public partial class BillingManagementClient : ServiceClient<BillingManagementClient>, IBillingManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Version of the API to be used with the client request. The current version
        /// is 2018-11-01-preview.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Azure Subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IBillingAccountsOperations.
        /// </summary>
        public virtual IBillingAccountsOperations BillingAccounts { get; private set; }

        /// <summary>
        /// Gets the IAvailableBalanceOperations.
        /// </summary>
        public virtual IAvailableBalanceOperations AvailableBalance { get; private set; }

        /// <summary>
        /// Gets the IPaymentMethodsOperations.
        /// </summary>
        public virtual IPaymentMethodsOperations PaymentMethods { get; private set; }

        /// <summary>
        /// Gets the IBillingProfilesOperations.
        /// </summary>
        public virtual IBillingProfilesOperations BillingProfiles { get; private set; }

        /// <summary>
        /// Gets the IInvoiceSectionsOperations.
        /// </summary>
        public virtual IInvoiceSectionsOperations InvoiceSections { get; private set; }

        /// <summary>
        /// Gets the IDepartmentsOperations.
        /// </summary>
        public virtual IDepartmentsOperations Departments { get; private set; }

        /// <summary>
        /// Gets the IEnrollmentAccountsOperations.
        /// </summary>
        public virtual IEnrollmentAccountsOperations EnrollmentAccounts { get; private set; }

        /// <summary>
        /// Gets the IInvoicesOperations.
        /// </summary>
        public virtual IInvoicesOperations Invoices { get; private set; }

        /// <summary>
        /// Gets the IPriceSheetOperations.
        /// </summary>
        public virtual IPriceSheetOperations PriceSheet { get; private set; }

        /// <summary>
        /// Gets the IBillingSubscriptionsOperations.
        /// </summary>
        public virtual IBillingSubscriptionsOperations BillingSubscriptions { get; private set; }

        /// <summary>
        /// Gets the IProductsOperations.
        /// </summary>
        public virtual IProductsOperations Products { get; private set; }

        /// <summary>
        /// Gets the ITransactionsOperations.
        /// </summary>
        public virtual ITransactionsOperations Transactions { get; private set; }

        /// <summary>
        /// Gets the IPolicyOperations.
        /// </summary>
        public virtual IPolicyOperations Policy { get; private set; }

        /// <summary>
        /// Gets the IBillingPropertyOperations.
        /// </summary>
        public virtual IBillingPropertyOperations BillingProperty { get; private set; }

        /// <summary>
        /// Gets the ITransfersOperations.
        /// </summary>
        public virtual ITransfersOperations Transfers { get; private set; }

        /// <summary>
        /// Gets the IRecipientTransfersOperations.
        /// </summary>
        public virtual IRecipientTransfersOperations RecipientTransfers { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IBillingPermissionsOperations.
        /// </summary>
        public virtual IBillingPermissionsOperations BillingPermissions { get; private set; }

        /// <summary>
        /// Gets the IBillingProfileBillingPermissionsOperations.
        /// </summary>
        public virtual IBillingProfileBillingPermissionsOperations BillingProfileBillingPermissions { get; private set; }

        /// <summary>
        /// Gets the IBillingRoleDefinitionOperations.
        /// </summary>
        public virtual IBillingRoleDefinitionOperations BillingRoleDefinition { get; private set; }

        /// <summary>
        /// Gets the IBillingRoleAssignmentOperations.
        /// </summary>
        public virtual IBillingRoleAssignmentOperations BillingRoleAssignment { get; private set; }

        /// <summary>
        /// Gets the IAgreementsOperations.
        /// </summary>
        public virtual IAgreementsOperations Agreements { get; private set; }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling BillingManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected BillingManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected BillingManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected BillingManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected BillingManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected BillingManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BillingManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling BillingManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BillingManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BillingManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BillingManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the BillingManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BillingManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            BillingAccounts = new BillingAccountsOperations(this);
            AvailableBalance = new AvailableBalanceOperations(this);
            PaymentMethods = new PaymentMethodsOperations(this);
            BillingProfiles = new BillingProfilesOperations(this);
            InvoiceSections = new InvoiceSectionsOperations(this);
            Departments = new DepartmentsOperations(this);
            EnrollmentAccounts = new EnrollmentAccountsOperations(this);
            Invoices = new InvoicesOperations(this);
            PriceSheet = new PriceSheetOperations(this);
            BillingSubscriptions = new BillingSubscriptionsOperations(this);
            Products = new ProductsOperations(this);
            Transactions = new TransactionsOperations(this);
            Policy = new PolicyOperations(this);
            BillingProperty = new BillingPropertyOperations(this);
            Transfers = new TransfersOperations(this);
            RecipientTransfers = new RecipientTransfersOperations(this);
            Operations = new Operations(this);
            BillingPermissions = new BillingPermissionsOperations(this);
            BillingProfileBillingPermissions = new BillingProfileBillingPermissionsOperations(this);
            BillingRoleDefinition = new BillingRoleDefinitionOperations(this);
            BillingRoleAssignment = new BillingRoleAssignmentOperations(this);
            Agreements = new AgreementsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2018-11-01-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
