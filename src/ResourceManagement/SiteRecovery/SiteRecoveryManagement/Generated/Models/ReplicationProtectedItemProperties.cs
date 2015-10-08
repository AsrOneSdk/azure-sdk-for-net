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
    public partial class ReplicationProtectedItemProperties
    {
        private string _activeLocation;
        
        /// <summary>
        /// Optional. Gets or sets the Current active location of the PE.
        /// </summary>
        public string ActiveLocation
        {
            get { return this._activeLocation; }
            set { this._activeLocation = value; }
        }
        
        private IList<string> _allowedOperations;
        
        /// <summary>
        /// Optional. Gets or sets the allowed operations on the Replication
        /// protected item.
        /// </summary>
        public IList<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }
        
        private CurrentScenarioDetails _currentScenario;
        
        /// <summary>
        /// Optional. Gets or sets the current scenario.
        /// </summary>
        public CurrentScenarioDetails CurrentScenario
        {
            get { return this._currentScenario; }
            set { this._currentScenario = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the name.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private System.DateTime? _lastSuccessfulFailoverTime;
        
        /// <summary>
        /// Optional. Gets or sets the Last successful failover time.
        /// </summary>
        public System.DateTime? LastSuccessfulFailoverTime
        {
            get { return this._lastSuccessfulFailoverTime; }
            set { this._lastSuccessfulFailoverTime = value; }
        }
        
        private System.DateTime? _lastSuccessfulTestFailoverTime;
        
        /// <summary>
        /// Optional. Gets or sets the Last successful test failover time.
        /// </summary>
        public System.DateTime? LastSuccessfulTestFailoverTime
        {
            get { return this._lastSuccessfulTestFailoverTime; }
            set { this._lastSuccessfulTestFailoverTime = value; }
        }
        
        private string _policyFriendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the name of Policy governing this PE.
        /// </summary>
        public string PolicyFriendlyName
        {
            get { return this._policyFriendlyName; }
            set { this._policyFriendlyName = value; }
        }
        
        private string _policyID;
        
        /// <summary>
        /// Optional. Gets or sets the ID of Policy governing this PE.
        /// </summary>
        public string PolicyID
        {
            get { return this._policyID; }
            set { this._policyID = value; }
        }
        
        private string _primaryFabricFriendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the friendly name of the primary fabric.
        /// </summary>
        public string PrimaryFabricFriendlyName
        {
            get { return this._primaryFabricFriendlyName; }
            set { this._primaryFabricFriendlyName = value; }
        }
        
        private string _primaryProtectionContainerFriendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the name of primary protection container
        /// friendly name.
        /// </summary>
        public string PrimaryProtectionContainerFriendlyName
        {
            get { return this._primaryProtectionContainerFriendlyName; }
            set { this._primaryProtectionContainerFriendlyName = value; }
        }
        
        private string _protectedItemId;
        
        /// <summary>
        /// Optional. Gets or sets the protected item Id.
        /// </summary>
        public string ProtectedItemId
        {
            get { return this._protectedItemId; }
            set { this._protectedItemId = value; }
        }
        
        private string _protectedItemType;
        
        /// <summary>
        /// Optional. Gets or sets the type of protected item type.
        /// </summary>
        public string ProtectedItemType
        {
            get { return this._protectedItemType; }
            set { this._protectedItemType = value; }
        }
        
        private string _protectionState;
        
        /// <summary>
        /// Optional. Gets or sets the protection status.
        /// </summary>
        public string ProtectionState
        {
            get { return this._protectionState; }
            set { this._protectionState = value; }
        }
        
        private ReplicationProviderSpecificSettings _providerSpecificDetails;
        
        /// <summary>
        /// Optional. Gets or sets the Replication provider custom settings.
        /// </summary>
        public ReplicationProviderSpecificSettings ProviderSpecificDetails
        {
            get { return this._providerSpecificDetails; }
            set { this._providerSpecificDetails = value; }
        }
        
        private string _recoveryFabricFriendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the friendly name of recovery fabric.
        /// </summary>
        public string RecoveryFabricFriendlyName
        {
            get { return this._recoveryFabricFriendlyName; }
            set { this._recoveryFabricFriendlyName = value; }
        }
        
        private string _recoveryProtectionContainerFriendlyName;
        
        /// <summary>
        /// Optional. Gets or sets the name of recovery container friendly name.
        /// </summary>
        public string RecoveryProtectionContainerFriendlyName
        {
            get { return this._recoveryProtectionContainerFriendlyName; }
            set { this._recoveryProtectionContainerFriendlyName = value; }
        }
        
        private string _recoveryServicesProviderName;
        
        /// <summary>
        /// Optional. Gets or sets the recovery provider name.
        /// </summary>
        public string RecoveryServicesProviderName
        {
            get { return this._recoveryServicesProviderName; }
            set { this._recoveryServicesProviderName = value; }
        }
        
        private string _replicationHealth;
        
        /// <summary>
        /// Optional. Gets or sets the consolidated protection health
        /// </summary>
        public string ReplicationHealth
        {
            get { return this._replicationHealth; }
            set { this._replicationHealth = value; }
        }
        
        private IList<HealthError> _replicationHealthErrors;
        
        /// <summary>
        /// Optional. Gets or sets list of replication health errors.
        /// </summary>
        public IList<HealthError> ReplicationHealthErrors
        {
            get { return this._replicationHealthErrors; }
            set { this._replicationHealthErrors = value; }
        }
        
        private string _replicationProvider;
        
        /// <summary>
        /// Optional.  Gets or sets the Replication provider governing this PE
        /// currently.
        /// </summary>
        public string ReplicationProvider
        {
            get { return this._replicationProvider; }
            set { this._replicationProvider = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties()
        {
            this.AllowedOperations = new LazyList<string>();
            this.ReplicationHealthErrors = new LazyList<HealthError>();
        }
    }
}
