//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Net.Http;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public partial class SiteRecoveryManagementClient
    {
        /// <summary>
        /// donot allow dispose incase the http client is shared.
        /// </summary>
        private bool donotAllowDispose = false;

        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='resourceType'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Required. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client.
        /// </param>
        /// <param name='donotAllowDisposeOnHttpClient'>
        /// True if Http client is intended to be shared and not supposed to be disposed.
        /// </param>
        public SiteRecoveryManagementClient(string resourceName, string resourceGroupName, string resourceNamespace, string resourceType, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient, bool donotAllowDisposeOnHttpClient)
            : base(httpClient)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }

            // Initialize the variables.
            this._alertSettings = new AlertSettingsOperations(this);
            this._events = new EventOperations(this);
            this._fabrics = new FabricOperations(this);
            this._jobs = new JobOperations(this);
            this._logicalNetwork = new LogicalNetworkOperations(this);
            this._networkMapping = new NetworkMappingOperations(this);
            this._network = new NetworkOperations(this);
            this._policies = new PolicyOperations(this);
            this._protectableItem = new ProtectableItemOperations(this);
            this._protectionContainerMapping = new ProtectionContainerMappingOperations(this);
            this._protectionContainer = new ProtectionContainerOperations(this);
            this._recoveryPlan = new RecoveryPlanOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._recoveryServicesProvider = new RecoveryServicesProviderOperations(this);
            this._replicationProtectedItem = new ReplicationProtectedItemOperations(this);
            this._storageClassificationMapping = new StorageClassificationMappingOperations(this);
            this._storageClassification = new StorageClassificationOperations(this);
            this._vaults = new VaultHealthOperations(this);
            this._vCenters = new VCenterOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;

            // Set if the underneath http client is supposed to be disposed or not.
            this.donotAllowDispose = donotAllowDisposeOnHttpClient;
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._resourceNamespace = resourceNamespace;
            this._resourceType = resourceType;
            this._credentials = credentials;
            this._baseUri = baseUri;

            this.Credentials.InitializeServiceClient(this);
        }

        /// <summary>
        ///  Override the dispose method.
        /// </summary>
        public override void Dispose()
        {
            if (this.donotAllowDispose)
                return;
            base.Dispose();
        }
    }
}
