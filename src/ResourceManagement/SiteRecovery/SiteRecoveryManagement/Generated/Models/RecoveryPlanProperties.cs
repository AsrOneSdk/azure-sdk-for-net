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
    /// Recovery plan properties object.
    /// </summary>
    public partial class RecoveryPlanProperties
    {
        private IList<string> _allowedOperations;
        
        /// <summary>
        /// Optional. Allowed operations on the recovery plan.
        /// </summary>
        public IList<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }
        
        private CurrentScenarioDetails _currentScenario;
        
        /// <summary>
        /// Optional. Current scenario object.
        /// </summary>
        public CurrentScenarioDetails CurrentScenario
        {
            get { return this._currentScenario; }
            set { this._currentScenario = value; }
        }
        
        private string _currentScenarioStatus;
        
        /// <summary>
        /// Optional. Current scenario status.
        /// </summary>
        public string CurrentScenarioStatus
        {
            get { return this._currentScenarioStatus; }
            set { this._currentScenarioStatus = value; }
        }
        
        private string _currentScenarioStatusDescription;
        
        /// <summary>
        /// Optional. Current scenario status description.
        /// </summary>
        public string CurrentScenarioStatusDescription
        {
            get { return this._currentScenarioStatusDescription; }
            set { this._currentScenarioStatusDescription = value; }
        }
        
        private string _failoverDeploymentModel;
        
        /// <summary>
        /// Optional. Failover deployment model.
        /// </summary>
        public string FailoverDeploymentModel
        {
            get { return this._failoverDeploymentModel; }
            set { this._failoverDeploymentModel = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the recovery plan.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private IList<RecoveryPlanGroup> _groups;
        
        /// <summary>
        /// Optional. Recovery plan groups list.
        /// </summary>
        public IList<RecoveryPlanGroup> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }
        
        private System.DateTime? _lastPlannedFailoverTime;
        
        /// <summary>
        /// Optional. Last planned failover time.
        /// </summary>
        public System.DateTime? LastPlannedFailoverTime
        {
            get { return this._lastPlannedFailoverTime; }
            set { this._lastPlannedFailoverTime = value; }
        }
        
        private System.DateTime? _lastTestFailoverTime;
        
        /// <summary>
        /// Optional. Last test failover time.
        /// </summary>
        public System.DateTime? LastTestFailoverTime
        {
            get { return this._lastTestFailoverTime; }
            set { this._lastTestFailoverTime = value; }
        }
        
        private System.DateTime? _lastUnplannedFailoverTime;
        
        /// <summary>
        /// Optional. Last unplanned failover time.
        /// </summary>
        public System.DateTime? LastUnplannedFailoverTime
        {
            get { return this._lastUnplannedFailoverTime; }
            set { this._lastUnplannedFailoverTime = value; }
        }
        
        private string _primaryFabricFriendlyName;
        
        /// <summary>
        /// Optional. Primary fabric friendly name.
        /// </summary>
        public string PrimaryFabricFriendlyName
        {
            get { return this._primaryFabricFriendlyName; }
            set { this._primaryFabricFriendlyName = value; }
        }
        
        private string _primaryFabricId;
        
        /// <summary>
        /// Required. Primary fabric Id.
        /// </summary>
        public string PrimaryFabricId
        {
            get { return this._primaryFabricId; }
            set { this._primaryFabricId = value; }
        }
        
        private string _recoveryFabricFriendlyName;
        
        /// <summary>
        /// Optional. Recovery fabric friendly name.
        /// </summary>
        public string RecoveryFabricFriendlyName
        {
            get { return this._recoveryFabricFriendlyName; }
            set { this._recoveryFabricFriendlyName = value; }
        }
        
        private string _recoveryFabricId;
        
        /// <summary>
        /// Required. Recovery fabric Id.
        /// </summary>
        public string RecoveryFabricId
        {
            get { return this._recoveryFabricId; }
            set { this._recoveryFabricId = value; }
        }
        
        private IList<string> _replicationProviders;
        
        /// <summary>
        /// Optional. List of replication providers.
        /// </summary>
        public IList<string> ReplicationProviders
        {
            get { return this._replicationProviders; }
            set { this._replicationProviders = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class.
        /// </summary>
        public RecoveryPlanProperties()
        {
            this.AllowedOperations = new LazyList<string>();
            this.Groups = new LazyList<RecoveryPlanGroup>();
            this.ReplicationProviders = new LazyList<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class with
        /// required arguments.
        /// </summary>
        public RecoveryPlanProperties(string primaryFabricId, string recoveryFabricId)
            : this()
        {
            if (primaryFabricId == null)
            {
                throw new ArgumentNullException("primaryFabricId");
            }
            if (recoveryFabricId == null)
            {
                throw new ArgumentNullException("recoveryFabricId");
            }
            this.PrimaryFabricId = primaryFabricId;
            this.RecoveryFabricId = recoveryFabricId;
        }
    }
}
