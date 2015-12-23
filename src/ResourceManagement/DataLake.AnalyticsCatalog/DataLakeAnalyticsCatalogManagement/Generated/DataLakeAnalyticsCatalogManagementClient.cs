// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.AnalyticsCatalog;
using Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models;

namespace Microsoft.Azure.Management.DataLake.AnalyticsCatalog
{
    /// <summary>
    /// Creates an Azure Data Lake Analytics catalog management client.
    /// </summary>
    public partial class DataLakeAnalyticsCatalogManagementClient : ServiceClient<DataLakeAnalyticsCatalogManagementClient>, IDataLakeAnalyticsCatalogManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private string _catalogServiceUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public string CatalogServiceUri
        {
            get { return this._catalogServiceUri; }
            set { this._catalogServiceUri = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _userAgentSuffix;
        
        /// <summary>
        /// Gets or sets the additional UserAgent text to be added to the user
        /// agent header. This is used to further differentiate where requests
        /// are coming from internally.
        /// </summary>
        public string UserAgentSuffix
        {
            get { return this._userAgentSuffix; }
            set { this._userAgentSuffix = value; }
        }
        
        private ICatalogOperations _catalog;
        
        /// <summary>
        /// Operations for managing the Data Lake Analytics catalog
        /// </summary>
        public virtual ICatalogOperations Catalog
        {
            get { return this._catalog; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        public DataLakeAnalyticsCatalogManagementClient()
            : base()
        {
            this._catalog = new CatalogOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='catalogServiceUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public DataLakeAnalyticsCatalogManagementClient(SubscriptionCloudCredentials credentials, string catalogServiceUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (catalogServiceUri == null)
            {
                throw new ArgumentNullException("catalogServiceUri");
            }
            this._credentials = credentials;
            this._catalogServiceUri = catalogServiceUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public DataLakeAnalyticsCatalogManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._catalogServiceUri = "azuredatalakeanalytics.net";
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsCatalogManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._catalog = new CatalogOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='catalogServiceUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsCatalogManagementClient(SubscriptionCloudCredentials credentials, string catalogServiceUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (catalogServiceUri == null)
            {
                throw new ArgumentNullException("catalogServiceUri");
            }
            this._credentials = credentials;
            this._catalogServiceUri = catalogServiceUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsCatalogManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._catalogServiceUri = "azuredatalakeanalytics.net";
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// DataLakeAnalyticsCatalogManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of DataLakeAnalyticsCatalogManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<DataLakeAnalyticsCatalogManagementClient> client)
        {
            base.Clone(client);
            
            if (client is DataLakeAnalyticsCatalogManagementClient)
            {
                DataLakeAnalyticsCatalogManagementClient clonedClient = ((DataLakeAnalyticsCatalogManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._userAgentSuffix = this._userAgentSuffix;
                clonedClient._catalogServiceUri = this._catalogServiceUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type FileType.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static FileType ParseFileType(string value)
        {
            if ("Assembly".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return FileType.ASSEMBLY;
            }
            if ("Resource".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return FileType.RESOURCE;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type FileType to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string FileTypeToString(FileType value)
        {
            if (value == FileType.ASSEMBLY)
            {
                return "Assembly";
            }
            if (value == FileType.RESOURCE)
            {
                return "Resource";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
