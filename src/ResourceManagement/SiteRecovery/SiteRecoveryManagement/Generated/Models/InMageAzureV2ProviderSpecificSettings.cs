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
    /// InMageAzureV2 Provider specific entity details.
    /// </summary>
    public partial class InMageAzureV2ProviderSpecificSettings : ReplicationProviderSpecificSettings
    {
        private string _agentVersion;
        
        /// <summary>
        /// Optional. Agent version.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private IList<AzureVmDiskDetails> _azureVMDiskDetails;
        
        /// <summary>
        /// Optional. Gets or sets Azure VM Disk details.
        /// </summary>
        public IList<AzureVmDiskDetails> AzureVMDiskDetails
        {
            get { return this._azureVMDiskDetails; }
            set { this._azureVMDiskDetails = value; }
        }
        
        private double _compressedDataRateInMB;
        
        /// <summary>
        /// Optional. Compressed data change rate in MB.
        /// </summary>
        public double CompressedDataRateInMB
        {
            get { return this._compressedDataRateInMB; }
            set { this._compressedDataRateInMB = value; }
        }
        
        private IList<string> _datastores;
        
        /// <summary>
        /// Optional. Gets or sets the data stores for the VM.
        /// </summary>
        public IList<string> Datastores
        {
            get { return this._datastores; }
            set { this._datastores = value; }
        }
        
        private string _discoveryType;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating the discovery type of the
        /// machine.Value can be vCenter or physical.
        /// </summary>
        public string DiscoveryType
        {
            get { return this._discoveryType; }
            set { this._discoveryType = value; }
        }
        
        private string _diskResized;
        
        /// <summary>
        /// Optional. Value indicating whether any disk is resized for this VM.
        /// </summary>
        public string DiskResized
        {
            get { return this._diskResized; }
            set { this._diskResized = value; }
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
        
        private string _infrastructureVmId;
        
        /// <summary>
        /// Optional. Infrastructure VM Id.
        /// </summary>
        public string InfrastructureVmId
        {
            get { return this._infrastructureVmId; }
            set { this._infrastructureVmId = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. Source IP address.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private string _isAgentUpdateRequired;
        
        /// <summary>
        /// Optional. Value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        public string IsAgentUpdateRequired
        {
            get { return this._isAgentUpdateRequired; }
            set { this._isAgentUpdateRequired = value; }
        }
        
        private string _isRebootAfterUpdateRequired;
        
        /// <summary>
        /// Optional. Value indicating whether the source server requires a
        /// restart after update.
        /// </summary>
        public string IsRebootAfterUpdateRequired
        {
            get { return this._isRebootAfterUpdateRequired; }
            set { this._isRebootAfterUpdateRequired = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. Last heartbeat received from the source server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
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
        
        private string _masterTargetId;
        
        /// <summary>
        /// Optional. Master target Id.
        /// </summary>
        public string MasterTargetId
        {
            get { return this._masterTargetId; }
            set { this._masterTargetId = value; }
        }
        
        private string _multiVmGroupId;
        
        /// <summary>
        /// Optional. Multi vm group Id.
        /// </summary>
        public string MultiVmGroupId
        {
            get { return this._multiVmGroupId; }
            set { this._multiVmGroupId = value; }
        }
        
        private string _multiVmGroupName;
        
        /// <summary>
        /// Optional. Multi vm group name.
        /// </summary>
        public string MultiVmGroupName
        {
            get { return this._multiVmGroupName; }
            set { this._multiVmGroupName = value; }
        }
        
        private string _oSDiskId;
        
        /// <summary>
        /// Optional. Id of the disk containing the OS.
        /// </summary>
        public string OSDiskId
        {
            get { return this._oSDiskId; }
            set { this._oSDiskId = value; }
        }
        
        private string _oSType;
        
        /// <summary>
        /// Optional. Type of the OS on the VM.
        /// </summary>
        public string OSType
        {
            get { return this._oSType; }
            set { this._oSType = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. Process server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        private IList<InMageAzureV2ProtectedDiskDetails> _protectedDisks;
        
        /// <summary>
        /// Optional. List of protected volumes.
        /// </summary>
        public IList<InMageAzureV2ProtectedDiskDetails> ProtectedDisks
        {
            get { return this._protectedDisks; }
            set { this._protectedDisks = value; }
        }
        
        private string _protectionStage;
        
        /// <summary>
        /// Optional. Protection stage.
        /// </summary>
        public string ProtectionStage
        {
            get { return this._protectionStage; }
            set { this._protectionStage = value; }
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
        /// Optional. Gets or sets the ARM id of the log storage acount used
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
        
        private int _resyncProgressPercentage;
        
        /// <summary>
        /// Optional. Resync progress percentage.
        /// </summary>
        public int ResyncProgressPercentage
        {
            get { return this._resyncProgressPercentage; }
            set { this._resyncProgressPercentage = value; }
        }
        
        private long? _rpoInSeconds;
        
        /// <summary>
        /// Optional. RPO in seconds.
        /// </summary>
        public long? RpoInSeconds
        {
            get { return this._rpoInSeconds; }
            set { this._rpoInSeconds = value; }
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
        
        private int _sourceVmCPUCount;
        
        /// <summary>
        /// Optional. CPU count of the VM on the primary side.
        /// </summary>
        public int SourceVmCPUCount
        {
            get { return this._sourceVmCPUCount; }
            set { this._sourceVmCPUCount = value; }
        }
        
        private int _sourceVmRAMSizeInMB;
        
        /// <summary>
        /// Optional. RAM size of the VM on the primary side.
        /// </summary>
        public int SourceVmRAMSizeInMB
        {
            get { return this._sourceVmRAMSizeInMB; }
            set { this._sourceVmRAMSizeInMB = value; }
        }
        
        private string _targetVmId;
        
        /// <summary>
        /// Optional. Gets or sets the ARM Id of the target Azure VM.
        /// </summary>
        public string TargetVmId
        {
            get { return this._targetVmId; }
            set { this._targetVmId = value; }
        }
        
        private double _uncompressedDataRateInMB;
        
        /// <summary>
        /// Optional. Uncompressed data change rate in MB.
        /// </summary>
        public double UncompressedDataRateInMB
        {
            get { return this._uncompressedDataRateInMB; }
            set { this._uncompressedDataRateInMB = value; }
        }
        
        private string _vCenterInfrastructureId;
        
        /// <summary>
        /// Optional. vCenter Infrastructure Id.
        /// </summary>
        public string VCenterInfrastructureId
        {
            get { return this._vCenterInfrastructureId; }
            set { this._vCenterInfrastructureId = value; }
        }
        
        private string _vHDName;
        
        /// <summary>
        /// Optional. OS disk VHD name.
        /// </summary>
        public string VHDName
        {
            get { return this._vHDName; }
            set { this._vHDName = value; }
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
        /// InMageAzureV2ProviderSpecificSettings class.
        /// </summary>
        public InMageAzureV2ProviderSpecificSettings()
        {
            this.AzureVMDiskDetails = new LazyList<AzureVmDiskDetails>();
            this.Datastores = new LazyList<string>();
            this.ProtectedDisks = new LazyList<InMageAzureV2ProtectedDiskDetails>();
            this.VMNics = new LazyList<VMNicDetails>();
        }
    }
}
