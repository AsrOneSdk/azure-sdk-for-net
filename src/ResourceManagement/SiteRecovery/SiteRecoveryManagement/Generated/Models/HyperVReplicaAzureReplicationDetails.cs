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
    /// Hyper V Replica Azure Provider specific entity details.
    /// </summary>
    public partial class HyperVReplicaAzureReplicationDetails : ReplicationProviderSpecificSettings
    {
        private IList<AzureVmDiskDetails> _azureVMDiskDetails;
        
        /// <summary>
        /// Optional. Gets or sets Azure VM Disk details.
        /// </summary>
        public IList<AzureVmDiskDetails> AzureVMDiskDetails
        {
            get { return this._azureVMDiskDetails; }
            set { this._azureVMDiskDetails = value; }
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
        
        private string _encryption;
        
        /// <summary>
        /// Optional. Gets or sets the encryption info.
        /// </summary>
        public string Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }
        
        private InitialReplicationDetails _initialReplicationDetails;
        
        /// <summary>
        /// Optional. Gets or sets initial replication details.
        /// </summary>
        public InitialReplicationDetails InitialReplicationDetails
        {
            get { return this._initialReplicationDetails; }
            set { this._initialReplicationDetails = value; }
        }
        
        private System.DateTime? _lastReplicatedTime;
        
        /// <summary>
        /// Optional. Gets or sets the Last replication time.
        /// </summary>
        public System.DateTime? LastReplicatedTime
        {
            get { return this._lastReplicatedTime; }
            set { this._lastReplicatedTime = value; }
        }
        
        private string _licenseType;
        
        /// <summary>
        /// Optional. Gets or sets License Type of the VM to be used for HUB
        /// https://azure.microsoft.com/en-in/pricing/hybrid-use-benefit/.
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }
        
        private OSDetails _oSDetails;
        
        /// <summary>
        /// Optional. Type of the OS on the VM.
        /// </summary>
        public OSDetails OSDetails
        {
            get { return this._oSDetails; }
            set { this._oSDetails = value; }
        }
        
        private string _recoveryAvailabilitySetId;
        
        /// <summary>
        /// Optional. Gets or set the recovery Azure availability set Id.
        /// </summary>
        public string RecoveryAvailabilitySetId
        {
            get { return this._recoveryAvailabilitySetId; }
            set { this._recoveryAvailabilitySetId = value; }
        }
        
        private string _recoveryAzureLogStorageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the ARM id of the log storage account used
        /// for replication.This will be set to null if no log storage account
        /// was provided during enableprotection.
        /// </summary>
        public string RecoveryAzureLogStorageAccountId
        {
            get { return this._recoveryAzureLogStorageAccountId; }
            set { this._recoveryAzureLogStorageAccountId = value; }
        }
        
        private string _recoveryAzureResourceGroupId;
        
        /// <summary>
        /// Optional. Gets or sets the recovery Azure resource group Id.
        /// </summary>
        public string RecoveryAzureResourceGroupId
        {
            get { return this._recoveryAzureResourceGroupId; }
            set { this._recoveryAzureResourceGroupId = value; }
        }
        
        private string _recoveryAzureStorageAccount;
        
        /// <summary>
        /// Optional. Gets or sets the recovery Azure storage account.
        /// </summary>
        public string RecoveryAzureStorageAccount
        {
            get { return this._recoveryAzureStorageAccount; }
            set { this._recoveryAzureStorageAccount = value; }
        }
        
        private string _recoveryAzureVMName;
        
        /// <summary>
        /// Optional. Gets or sets Recovery Azure given name.
        /// </summary>
        public string RecoveryAzureVMName
        {
            get { return this._recoveryAzureVMName; }
            set { this._recoveryAzureVMName = value; }
        }
        
        private string _recoveryAzureVMSize;
        
        /// <summary>
        /// Optional. Gets or sets the Recovery Azure VM size.
        /// </summary>
        public string RecoveryAzureVMSize
        {
            get { return this._recoveryAzureVMSize; }
            set { this._recoveryAzureVMSize = value; }
        }
        
        private string _selectedRecoveryAzureNetworkId;
        
        /// <summary>
        /// Optional. Gets or sets the selected recovery azure network Id.
        /// </summary>
        public string SelectedRecoveryAzureNetworkId
        {
            get { return this._selectedRecoveryAzureNetworkId; }
            set { this._selectedRecoveryAzureNetworkId = value; }
        }
        
        private string _selectedSourceNicId;
        
        /// <summary>
        /// Optional. Gets or sets the selected source nic id which will be
        /// used as the primary nic during failover.
        /// </summary>
        public string SelectedSourceNicId
        {
            get { return this._selectedSourceNicId; }
            set { this._selectedSourceNicId = value; }
        }
        
        private int _sourceVmCPUCount;
        
        /// <summary>
        /// Optional. Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        public int SourceVmCPUCount
        {
            get { return this._sourceVmCPUCount; }
            set { this._sourceVmCPUCount = value; }
        }
        
        private int _sourceVmRAMSizeInMB;
        
        /// <summary>
        /// Optional. Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        public int SourceVmRAMSizeInMB
        {
            get { return this._sourceVmRAMSizeInMB; }
            set { this._sourceVmRAMSizeInMB = value; }
        }
        
        private string _useManagedDisks;
        
        /// <summary>
        /// Optional. Gets or sets the flag indicating if managed disks should
        /// be used.Will be 'True' if managed disks are to be used, and
        /// 'False' otherwise.
        /// </summary>
        public string UseManagedDisks
        {
            get { return this._useManagedDisks; }
            set { this._useManagedDisks = value; }
        }
        
        private string _vmId;
        
        /// <summary>
        /// Optional. Virtual machine Id.
        /// </summary>
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }
        
        private IList<VMNicDetails> _vMNics;
        
        /// <summary>
        /// Optional. Gets or sets the network details.
        /// </summary>
        public IList<VMNicDetails> VMNics
        {
            get { return this._vMNics; }
            set { this._vMNics = value; }
        }
        
        private string _vmProtectionState;
        
        /// <summary>
        /// Optional. Gets or sets the protection status for the VM.
        /// </summary>
        public string VmProtectionState
        {
            get { return this._vmProtectionState; }
            set { this._vmProtectionState = value; }
        }
        
        private string _vmProtectionStateDescription;
        
        /// <summary>
        /// Optional. Gets or sets the protection state description for the VM.
        /// </summary>
        public string VmProtectionStateDescription
        {
            get { return this._vmProtectionStateDescription; }
            set { this._vmProtectionStateDescription = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureReplicationDetails class.
        /// </summary>
        public HyperVReplicaAzureReplicationDetails()
        {
            this.AzureVMDiskDetails = new LazyList<AzureVmDiskDetails>();
            this.VMNics = new LazyList<VMNicDetails>();
        }
    }
}
