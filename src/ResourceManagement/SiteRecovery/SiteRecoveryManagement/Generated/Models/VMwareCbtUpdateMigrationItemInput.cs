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
    /// The VMwareCbt update migration ite, input.
    /// </summary>
    public partial class VMwareCbtUpdateMigrationItemInput : UpdateMigrationItemProviderSpecificInput
    {
        private string _licenseType;
        
        /// <summary>
        /// Optional. Gets or sets License Type of the VM.
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }
        
        private string _targetAvailabilitySetId;
        
        /// <summary>
        /// Optional. Target availability set Id.
        /// </summary>
        public string TargetAvailabilitySetId
        {
            get { return this._targetAvailabilitySetId; }
            set { this._targetAvailabilitySetId = value; }
        }
        
        private string _targetBootDiagnosticsStorageAccountId;
        
        /// <summary>
        /// Optional. Target boot diagnostics storage account Id.
        /// </summary>
        public string TargetBootDiagnosticsStorageAccountId
        {
            get { return this._targetBootDiagnosticsStorageAccountId; }
            set { this._targetBootDiagnosticsStorageAccountId = value; }
        }
        
        private string _targetNetworkId;
        
        /// <summary>
        /// Optional. Target network ARM Id.
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
        
        private IList<VMwareCbtNicInput> _vmNics;
        
        /// <summary>
        /// Required. Gets or sets VM Nic Details
        /// </summary>
        public IList<VMwareCbtNicInput> VmNics
        {
            get { return this._vmNics; }
            set { this._vmNics = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtUpdateMigrationItemInput
        /// class.
        /// </summary>
        public VMwareCbtUpdateMigrationItemInput()
        {
            this.VmNics = new LazyList<VMwareCbtNicInput>();
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtUpdateMigrationItemInput
        /// class with required arguments.
        /// </summary>
        public VMwareCbtUpdateMigrationItemInput(List<VMwareCbtNicInput> vmNics)
            : this()
        {
            if (vmNics == null)
            {
                throw new ArgumentNullException("vmNics");
            }
            this.VmNics = vmNics;
        }
    }
}
