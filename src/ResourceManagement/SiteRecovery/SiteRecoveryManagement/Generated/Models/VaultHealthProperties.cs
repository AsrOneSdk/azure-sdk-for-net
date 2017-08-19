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
    /// The definition of vault health Properties.
    /// </summary>
    public partial class VaultHealthProperties
    {
        private ResourceHealthSummary _fabricsHealth;
        
        /// <summary>
        /// Optional. The list of the health detail of the fabrics in the vault.
        /// </summary>
        public ResourceHealthSummary FabricsHealth
        {
            get { return this._fabricsHealth; }
            set { this._fabricsHealth = value; }
        }
        
        private ResourceHealthSummary _protectedItemsHealth;
        
        /// <summary>
        /// Optional. The list of the health detail of the protected items in
        /// the vault.
        /// </summary>
        public ResourceHealthSummary ProtectedItemsHealth
        {
            get { return this._protectedItemsHealth; }
            set { this._protectedItemsHealth = value; }
        }
        
        private IList<HealthError> _vaultErrors;
        
        /// <summary>
        /// Optional. The list of errors on the vault.
        /// </summary>
        public IList<HealthError> VaultErrors
        {
            get { return this._vaultErrors; }
            set { this._vaultErrors = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VaultHealthProperties class.
        /// </summary>
        public VaultHealthProperties()
        {
            this.VaultErrors = new LazyList<HealthError>();
        }
    }
}
