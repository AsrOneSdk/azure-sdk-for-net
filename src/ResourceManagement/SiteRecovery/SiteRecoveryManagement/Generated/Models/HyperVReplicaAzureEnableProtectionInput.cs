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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The Azure enable protection input.
    /// </summary>
    public partial class HyperVReplicaAzureEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        private IList<string> _disksToInclude;
        
        /// <summary>
        /// Optional. List of VHD IDs of disks to be protected.
        /// </summary>
        public IList<string> DisksToInclude
        {
            get { return this._disksToInclude; }
            set { this._disksToInclude = value; }
        }
        
        private string _enableRDPOnTargetOption;
        
        /// <summary>
        /// Optional. Gets or sets the option to enable RDP on target vm after
        /// failover.Value can be Never, OnlyOnTestFailover or Always.
        /// </summary>
        public string EnableRDPOnTargetOption
        {
            get { return this._enableRDPOnTargetOption; }
            set { this._enableRDPOnTargetOption = value; }
        }
        
        private string _hvHostVmId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string HvHostVmId
        {
            get { return this._hvHostVmId; }
            set { this._hvHostVmId = value; }
        }
        
        private string _logStorageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the storage account to be used for logging
        /// during replication.This is needed when the target storage account
        /// is of premium type only.
        /// </summary>
        public string LogStorageAccountId
        {
            get { return this._logStorageAccountId; }
            set { this._logStorageAccountId = value; }
        }
        
        private string _oSType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OSType
        {
            get { return this._oSType; }
            set { this._oSType = value; }
        }
        
        private string _targetAzureNetworkId;
        
        /// <summary>
        /// Optional. The target Azure network ID.
        /// </summary>
        public string TargetAzureNetworkId
        {
            get { return this._targetAzureNetworkId; }
            set { this._targetAzureNetworkId = value; }
        }
        
        private string _targetAzureSubnetId;
        
        /// <summary>
        /// Optional. The target Azure subnet ID.
        /// </summary>
        public string TargetAzureSubnetId
        {
            get { return this._targetAzureSubnetId; }
            set { this._targetAzureSubnetId = value; }
        }
        
        private string _targetAzureV1ResourceGroupId;
        
        /// <summary>
        /// Optional. Gets or sets the Id of the target resource group (for
        /// classic deployment) in which the failover VM is to be created.
        /// </summary>
        public string TargetAzureV1ResourceGroupId
        {
            get { return this._targetAzureV1ResourceGroupId; }
            set { this._targetAzureV1ResourceGroupId = value; }
        }
        
        private string _targetAzureV2ResourceGroupId;
        
        /// <summary>
        /// Optional. Gets or sets the Id of the target resource group (for
        /// resource manager deployment) in which the failover VM is to be
        /// created.
        /// </summary>
        public string TargetAzureV2ResourceGroupId
        {
            get { return this._targetAzureV2ResourceGroupId; }
            set { this._targetAzureV2ResourceGroupId = value; }
        }
        
        private string _targetAzureVmName;
        
        /// <summary>
        /// Optional. The target Azure VM Name.
        /// </summary>
        public string TargetAzureVmName
        {
            get { return this._targetAzureVmName; }
            set { this._targetAzureVmName = value; }
        }
        
        private string _targetBootDiagStorageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the boot diagnostic storage account.
        /// </summary>
        public string TargetBootDiagStorageAccountId
        {
            get { return this._targetBootDiagStorageAccountId; }
            set { this._targetBootDiagStorageAccountId = value; }
        }
        
        private string _targetStorageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the storage account Id.
        /// </summary>
        public string TargetStorageAccountId
        {
            get { return this._targetStorageAccountId; }
            set { this._targetStorageAccountId = value; }
        }
        
        private string _useManagedDisks;
        
        /// <summary>
        /// Optional. Gets or sets the value indicating if managed disks should
        /// be used.Should be 'True' if managed disks are to be used, and
        /// 'False' otherwise.
        /// </summary>
        public string UseManagedDisks
        {
            get { return this._useManagedDisks; }
            set { this._useManagedDisks = value; }
        }
        
        private string _vhdId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VhdId
        {
            get { return this._vhdId; }
            set { this._vhdId = value; }
        }
        
        private string _vmName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureEnableProtectionInput class.
        /// </summary>
        public HyperVReplicaAzureEnableProtectionInput()
        {
            this.DisksToInclude = new LazyList<string>();
        }
    }
}
