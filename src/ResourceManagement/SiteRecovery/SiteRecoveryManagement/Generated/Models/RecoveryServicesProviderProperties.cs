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
    /// The definition of a recovery services provider properties.
    /// </summary>
    public partial class RecoveryServicesProviderProperties
    {
        private string _connectionStatus;
        
        /// <summary>
        /// Optional. Denotes whether provider is responsive..
        /// </summary>
        public string ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }
        
        private string _fabricName;
        
        /// <summary>
        /// Optional. Unique name of the Fabric.
        /// </summary>
        public string FabricName
        {
            get { return this._fabricName; }
            set { this._fabricName = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the DRA.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private System.DateTime? _lastHeartBeatReceived;
        
        /// <summary>
        /// Optional. Time when last heartbeat was sent by the DRA.
        /// </summary>
        public System.DateTime? LastHeartBeatReceived
        {
            get { return this._lastHeartBeatReceived; }
            set { this._lastHeartBeatReceived = value; }
        }
        
        private string _refreshSupport;
        
        /// <summary>
        /// Optional. Indicates whether the DRA supports refresh operation.
        /// </summary>
        public string RefreshSupport
        {
            get { return this._refreshSupport; }
            set { this._refreshSupport = value; }
        }
        
        private int _replicationPECount;
        
        /// <summary>
        /// Optional. Number of protected entities currently managed by the
        /// provider.
        /// </summary>
        public int ReplicationPECount
        {
            get { return this._replicationPECount; }
            set { this._replicationPECount = value; }
        }
        
        private RecoveryServicesProviderVersionDetails _versionDetails;
        
        /// <summary>
        /// Optional. Version details of the DRA.
        /// </summary>
        public RecoveryServicesProviderVersionDetails VersionDetails
        {
            get { return this._versionDetails; }
            set { this._versionDetails = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesProviderProperties class.
        /// </summary>
        public RecoveryServicesProviderProperties()
        {
        }
    }
}
