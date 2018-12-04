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
    /// VMwareCbt provider specific details.
    /// </summary>
    public partial class VMwareCbtMigrationDetails : MigrationProviderSpecificSettings
    {
        private string _dataMoverRunAsAccountId;
        
        /// <summary>
        /// Optional. The data mover runas account Id
        /// </summary>
        public string DataMoverRunAsAccountId
        {
            get { return this._dataMoverRunAsAccountId; }
            set { this._dataMoverRunAsAccountId = value; }
        }
        
        private int? _initialSeedingProgressPercentage;
        
        /// <summary>
        /// Optional. The initial seeding progress percentage.
        /// </summary>
        public int? InitialSeedingProgressPercentage
        {
            get { return this._initialSeedingProgressPercentage; }
            set { this._initialSeedingProgressPercentage = value; }
        }
        
        private System.DateTime? _lastRecoveryPointReceived;
        
        /// <summary>
        /// Optional. The last recovery point received time.
        /// </summary>
        public System.DateTime? LastRecoveryPointReceived
        {
            get { return this._lastRecoveryPointReceived; }
            set { this._lastRecoveryPointReceived = value; }
        }
        
        private string _licenseType;
        
        /// <summary>
        /// Optional. License Type of the VM.
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }
        
        private int? _migrationProgressPercentage;
        
        /// <summary>
        /// Optional. The migration progress percentage.
        /// </summary>
        public int? MigrationProgressPercentage
        {
            get { return this._migrationProgressPercentage; }
            set { this._migrationProgressPercentage = value; }
        }
        
        private string _migrationRecoveryPointId;
        
        /// <summary>
        /// Optional.  The recovery point Id to which the VM was migrated.
        /// </summary>
        public string MigrationRecoveryPointId
        {
            get { return this._migrationRecoveryPointId; }
            set { this._migrationRecoveryPointId = value; }
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
        
        private IList<VMwareCbtProtectedDiskDetails> _protectedDisks;
        
        /// <summary>
        /// Optional. Protected disk details.
        /// </summary>
        public IList<VMwareCbtProtectedDiskDetails> ProtectedDisks
        {
            get { return this._protectedDisks; }
            set { this._protectedDisks = value; }
        }
        
        private string _snapshotRunAsAccountId;
        
        /// <summary>
        /// Optional. The snapshot runas account Id
        /// </summary>
        public string SnapshotRunAsAccountId
        {
            get { return this._snapshotRunAsAccountId; }
            set { this._snapshotRunAsAccountId = value; }
        }
        
        private string _storageAccountId;
        
        /// <summary>
        /// Optional. Storage account ARM Id.
        /// </summary>
        public string StorageAccountId
        {
            get { return this._storageAccountId; }
            set { this._storageAccountId = value; }
        }
        
        private string _targetAvailabilitySetId;
        
        /// <summary>
        /// Optional. Target Azure availability set Id.
        /// </summary>
        public string TargetAvailabilitySetId
        {
            get { return this._targetAvailabilitySetId; }
            set { this._targetAvailabilitySetId = value; }
        }
        
        private string _targetBootDiagnosticsStorageAccountId;
        
        /// <summary>
        /// Optional. Target boot diagnostics storage account ARM Id.
        /// </summary>
        public string TargetBootDiagnosticsStorageAccountId
        {
            get { return this._targetBootDiagnosticsStorageAccountId; }
            set { this._targetBootDiagnosticsStorageAccountId = value; }
        }
        
        private string _targetNetworkId;
        
        /// <summary>
        /// Optional. Target network Id.
        /// </summary>
        public string TargetNetworkId
        {
            get { return this._targetNetworkId; }
            set { this._targetNetworkId = value; }
        }
        
        private string _targetResourceGroupId;
        
        /// <summary>
        /// Optional. Target resource group Id.
        /// </summary>
        public string TargetResourceGroupId
        {
            get { return this._targetResourceGroupId; }
            set { this._targetResourceGroupId = value; }
        }
        
        private string _targetVmName;
        
        /// <summary>
        /// Optional. Target VM name.
        /// </summary>
        public string TargetVmName
        {
            get { return this._targetVmName; }
            set { this._targetVmName = value; }
        }
        
        private string _targetVmSize;
        
        /// <summary>
        /// Optional. Target VM size.
        /// </summary>
        public string TargetVmSize
        {
            get { return this._targetVmSize; }
            set { this._targetVmSize = value; }
        }
        
        private IList<VMwareCbtNicDetails> _vMNics;
        
        /// <summary>
        /// Optional. Gets or sets the network details.
        /// </summary>
        public IList<VMwareCbtNicDetails> VMNics
        {
            get { return this._vMNics; }
            set { this._vMNics = value; }
        }
        
        private string _vMwareMachineId;
        
        /// <summary>
        /// Optional. ARM Id of the VM discovered in VMware.
        /// </summary>
        public string VMwareMachineId
        {
            get { return this._vMwareMachineId; }
            set { this._vMwareMachineId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtMigrationDetails class.
        /// </summary>
        public VMwareCbtMigrationDetails()
        {
            this.ProtectedDisks = new LazyList<VMwareCbtProtectedDiskDetails>();
            this.VMNics = new LazyList<VMwareCbtNicDetails>();
        }
    }
}
