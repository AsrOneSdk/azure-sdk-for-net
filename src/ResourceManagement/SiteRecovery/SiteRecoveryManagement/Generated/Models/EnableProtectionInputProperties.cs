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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Protection Container pairing management object
    /// properties.
    /// </summary>
    public partial class EnableProtectionInputProperties
    {
        private string _policyId;
        
        /// <summary>
        /// Optional. The Policy ID.
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }
        
        private EnableProtectionProviderSpecificInput _providerConfigurationSettings;
        
        /// <summary>
        /// Optional. Gets or sets the ProviderSettings.
        /// </summary>
        public EnableProtectionProviderSpecificInput ProviderConfigurationSettings
        {
            get { return this._providerConfigurationSettings; }
            set { this._providerConfigurationSettings = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EnableProtectionInputProperties
        /// class.
        /// </summary>
        public EnableProtectionInputProperties()
        {
        }
    }
}
