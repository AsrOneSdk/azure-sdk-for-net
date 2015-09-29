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
    /// The definition of a server object.
    /// </summary>
    public partial class PolicyProperties
    {
        private string _friendlyName;
        
        /// <summary>
        /// Required. Name of replication provider
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private PolicyProviderSettingsDetails _providerSpecificDetails;
        
        /// <summary>
        /// Required. the replication provider settings
        /// </summary>
        public PolicyProviderSettingsDetails ProviderSpecificDetails
        {
            get { return this._providerSpecificDetails; }
            set { this._providerSpecificDetails = value; }
        }
        
        private string _recoveryProvider;
        
        /// <summary>
        /// Required. Name of replication provider
        /// </summary>
        public string RecoveryProvider
        {
            get { return this._recoveryProvider; }
            set { this._recoveryProvider = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PolicyProperties class.
        /// </summary>
        public PolicyProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PolicyProperties class with
        /// required arguments.
        /// </summary>
        public PolicyProperties(string friendlyName, string recoveryProvider, PolicyProviderSettingsDetails providerSpecificDetails)
            : this()
        {
            if (friendlyName == null)
            {
                throw new ArgumentNullException("friendlyName");
            }
            if (recoveryProvider == null)
            {
                throw new ArgumentNullException("recoveryProvider");
            }
            if (providerSpecificDetails == null)
            {
                throw new ArgumentNullException("providerSpecificDetails");
            }
            this.FriendlyName = friendlyName;
            this.RecoveryProvider = recoveryProvider;
            this.ProviderSpecificDetails = providerSpecificDetails;
        }
    }
}
