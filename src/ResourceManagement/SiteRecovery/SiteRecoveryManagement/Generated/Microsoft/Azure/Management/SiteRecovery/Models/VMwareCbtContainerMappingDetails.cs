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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// VMwareCbt provider specific details.
    /// </summary>
    public partial class VMwareCbtContainerMappingDetails : MappingProviderConfigurationSettings
    {
        private string _keyVaultArmId;
        
        /// <summary>
        /// Optional. Target key vault ARM Id.
        /// </summary>
        public string KeyVaultArmId
        {
            get { return this._keyVaultArmId; }
            set { this._keyVaultArmId = value; }
        }
        
        private string _keyVaultUri;
        
        /// <summary>
        /// Optional. Target key vault Uri.
        /// </summary>
        public string KeyVaultUri
        {
            get { return this._keyVaultUri; }
            set { this._keyVaultUri = value; }
        }
        
        private string _serviceBusConnectionStringSecretName;
        
        /// <summary>
        /// Optional. Service bus connection string secret name.
        /// </summary>
        public string ServiceBusConnectionStringSecretName
        {
            get { return this._serviceBusConnectionStringSecretName; }
            set { this._serviceBusConnectionStringSecretName = value; }
        }
        
        private string _storageAccountArmId;
        
        /// <summary>
        /// Optional. Storage account ARM Id.
        /// </summary>
        public string StorageAccountArmId
        {
            get { return this._storageAccountArmId; }
            set { this._storageAccountArmId = value; }
        }
        
        private string _storageAccountSasSecretName;
        
        /// <summary>
        /// Optional. Storage account SAS secret name.
        /// </summary>
        public string StorageAccountSasSecretName
        {
            get { return this._storageAccountSasSecretName; }
            set { this._storageAccountSasSecretName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtContainerMappingDetails
        /// class.
        /// </summary>
        public VMwareCbtContainerMappingDetails()
        {
        }
    }
}
