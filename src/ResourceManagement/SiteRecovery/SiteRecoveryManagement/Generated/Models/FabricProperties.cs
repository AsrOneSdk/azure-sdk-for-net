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
    /// The definition of a Fabric properties.
    /// </summary>
    public partial class FabricProperties
    {
        private string _bcdrState;
        
        /// <summary>
        /// Optional. BCDR state of the fabric.
        /// </summary>
        public string BcdrState
        {
            get { return this._bcdrState; }
            set { this._bcdrState = value; }
        }
        
        private FabricSpecificDetails _customDetails;
        
        /// <summary>
        /// Optional. Type of the fabric.
        /// </summary>
        public FabricSpecificDetails CustomDetails
        {
            get { return this._customDetails; }
            set { this._customDetails = value; }
        }
        
        private EncryptionDetails _encryptionDetails;
        
        /// <summary>
        /// Optional. Encryption details for the fabric.
        /// </summary>
        public EncryptionDetails EncryptionDetails
        {
            get { return this._encryptionDetails; }
            set { this._encryptionDetails = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the fabric.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _health;
        
        /// <summary>
        /// Optional. Health of fabric.
        /// </summary>
        public string Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        
        private IList<HealthError> _healthErrorDetails;
        
        /// <summary>
        /// Optional. List of fabric Health errors.
        /// </summary>
        public IList<HealthError> HealthErrorDetails
        {
            get { return this._healthErrorDetails; }
            set { this._healthErrorDetails = value; }
        }
        
        private string _internalIdentifier;
        
        /// <summary>
        /// Optional. Internal Identifier.
        /// </summary>
        public string InternalIdentifier
        {
            get { return this._internalIdentifier; }
            set { this._internalIdentifier = value; }
        }
        
        private EncryptionDetails _rolloverEncryptionDetails;
        
        /// <summary>
        /// Optional. Rollover encryption details for the fabric.
        /// </summary>
        public EncryptionDetails RolloverEncryptionDetails
        {
            get { return this._rolloverEncryptionDetails; }
            set { this._rolloverEncryptionDetails = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FabricProperties class.
        /// </summary>
        public FabricProperties()
        {
            this.HealthErrorDetails = new LazyList<HealthError>();
        }
    }
}
