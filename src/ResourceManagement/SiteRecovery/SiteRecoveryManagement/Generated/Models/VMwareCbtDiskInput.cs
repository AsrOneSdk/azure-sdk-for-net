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
    /// <summary>
    /// Enable migration disk input.
    /// </summary>
    public partial class VMwareCbtDiskInput
    {
        private string _diskId;
        
        /// <summary>
        /// Optional. The disk Id.
        /// </summary>
        public string DiskId
        {
            get { return this._diskId; }
            set { this._diskId = value; }
        }
        
        private string _diskType;
        
        /// <summary>
        /// Optional. Gets or sets disk type.
        /// </summary>
        public string DiskType
        {
            get { return this._diskType; }
            set { this._diskType = value; }
        }
        
        private string _isOSDisk;
        
        /// <summary>
        /// Optional. Indicates whether the disk is the OS disk.
        /// </summary>
        public string IsOSDisk
        {
            get { return this._isOSDisk; }
            set { this._isOSDisk = value; }
        }
        
        private string _logStorageAccountId;
        
        /// <summary>
        /// Optional. Log storage account ARM Id.
        /// </summary>
        public string LogStorageAccountId
        {
            get { return this._logStorageAccountId; }
            set { this._logStorageAccountId = value; }
        }
        
        private string _logStorageAccountSasSecretName;
        
        /// <summary>
        /// Optional. Key vault secret name of the log storage account.
        /// </summary>
        public string LogStorageAccountSasSecretName
        {
            get { return this._logStorageAccountSasSecretName; }
            set { this._logStorageAccountSasSecretName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtDiskInput class.
        /// </summary>
        public VMwareCbtDiskInput()
        {
        }
    }
}
