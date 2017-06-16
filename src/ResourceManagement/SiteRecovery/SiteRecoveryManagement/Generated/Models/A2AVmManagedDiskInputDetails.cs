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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    public partial class A2AVmManagedDiskInputDetails
    {
        private string _diskId;
        
        /// <summary>
        /// Optional. Primary managed disk Id.
        /// </summary>
        public string DiskId
        {
            get { return this._diskId; }
            set { this._diskId = value; }
        }
        
        private string _primaryStagingAzureStorageAccountId;
        
        /// <summary>
        /// Optional. Recovery Azure storage account ARM Id.
        /// </summary>
        public string PrimaryStagingAzureStorageAccountId
        {
            get { return this._primaryStagingAzureStorageAccountId; }
            set { this._primaryStagingAzureStorageAccountId = value; }
        }
        
        private string _recoveryResourceGroupId;
        
        /// <summary>
        /// Optional. Recovery azure resource group ARM Id.
        /// </summary>
        public string RecoveryResourceGroupId
        {
            get { return this._recoveryResourceGroupId; }
            set { this._recoveryResourceGroupId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the A2AVmManagedDiskInputDetails
        /// class.
        /// </summary>
        public A2AVmManagedDiskInputDetails()
        {
        }
    }
}
