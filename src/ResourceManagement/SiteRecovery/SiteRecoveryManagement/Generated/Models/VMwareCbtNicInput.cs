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
    /// VMwareCbt NIC input.
    /// </summary>
    public partial class VMwareCbtNicInput
    {
        private string _isPrimaryNic;
        
        /// <summary>
        /// Optional. Indicates whether this is the primary NIC.
        /// </summary>
        public string IsPrimaryNic
        {
            get { return this._isPrimaryNic; }
            set { this._isPrimaryNic = value; }
        }
        
        private string _isSelectedForMigration;
        
        /// <summary>
        /// Optional. Indicates whether this NIC is selected for migration.
        /// </summary>
        public string IsSelectedForMigration
        {
            get { return this._isSelectedForMigration; }
            set { this._isSelectedForMigration = value; }
        }
        
        private string _nicId;
        
        /// <summary>
        /// Optional. The NIC Id.
        /// </summary>
        public string NicId
        {
            get { return this._nicId; }
            set { this._nicId = value; }
        }
        
        private string _staticIPAddress;
        
        /// <summary>
        /// Optional. The static IP address.
        /// </summary>
        public string StaticIPAddress
        {
            get { return this._staticIPAddress; }
            set { this._staticIPAddress = value; }
        }
        
        private string _targetSubnetName;
        
        /// <summary>
        /// Optional. Storage account ARM Id.
        /// </summary>
        public string TargetSubnetName
        {
            get { return this._targetSubnetName; }
            set { this._targetSubnetName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VMwareCbtNicInput class.
        /// </summary>
        public VMwareCbtNicInput()
        {
        }
    }
}
