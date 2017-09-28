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
    /// The detaisl of a Process Server.
    /// </summary>
    public partial class ProcessServer
    {
        private string _agentVersion;
        
        /// <summary>
        /// Optional. The version of the scout component on the server.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private long _availableMemoryInBytes;
        
        /// <summary>
        /// Optional. The available memory.
        /// </summary>
        public long AvailableMemoryInBytes
        {
            get { return this._availableMemoryInBytes; }
            set { this._availableMemoryInBytes = value; }
        }
        
        private long _availableSpaceInBytes;
        
        /// <summary>
        /// Optional. The available space.
        /// </summary>
        public long AvailableSpaceInBytes
        {
            get { return this._availableSpaceInBytes; }
            set { this._availableSpaceInBytes = value; }
        }
        
        private string _cpuLoad;
        
        /// <summary>
        /// Optional. The percentage of the CPU load.
        /// </summary>
        public string CpuLoad
        {
            get { return this._cpuLoad; }
            set { this._cpuLoad = value; }
        }
        
        private string _cpuLoadStatus;
        
        /// <summary>
        /// Optional. The CPU load status.
        /// </summary>
        public string CpuLoadStatus
        {
            get { return this._cpuLoadStatus; }
            set { this._cpuLoadStatus = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. The Process Server's friendly name.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private IList<HealthError> _healthErrors;
        
        /// <summary>
        /// Optional. List of health errors.
        /// </summary>
        public IList<HealthError> HealthErrors
        {
            get { return this._healthErrors; }
            set { this._healthErrors = value; }
        }
        
        private string _hostId;
        
        /// <summary>
        /// Optional. The agent generated Id.
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The Process Server Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. The IP address of the server.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. The last heartbeat received from the server.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _memoryUsageStatus;
        
        /// <summary>
        /// Optional. The memory usage status.
        /// </summary>
        public string MemoryUsageStatus
        {
            get { return this._memoryUsageStatus; }
            set { this._memoryUsageStatus = value; }
        }
        
        private string _osType;
        
        /// <summary>
        /// Optional. The OS type of the server.
        /// </summary>
        public string OsType
        {
            get { return this._osType; }
            set { this._osType = value; }
        }
        
        private string _osVersion;
        
        /// <summary>
        /// Optional. The operating system version.
        /// </summary>
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }
        
        private string _psServiceStatus;
        
        /// <summary>
        /// Optional. The PS service status.
        /// </summary>
        public string PsServiceStatus
        {
            get { return this._psServiceStatus; }
            set { this._psServiceStatus = value; }
        }
        
        private string _replicationPairCount;
        
        /// <summary>
        /// Optional. The number of replication pairs configured in this PS.
        /// </summary>
        public string ReplicationPairCount
        {
            get { return this._replicationPairCount; }
            set { this._replicationPairCount = value; }
        }
        
        private string _serverCount;
        
        /// <summary>
        /// Optional. The servers configured with this PS.
        /// </summary>
        public string ServerCount
        {
            get { return this._serverCount; }
            set { this._serverCount = value; }
        }
        
        private string _spaceUsageStatus;
        
        /// <summary>
        /// Optional. The space usage status.
        /// </summary>
        public string SpaceUsageStatus
        {
            get { return this._spaceUsageStatus; }
            set { this._spaceUsageStatus = value; }
        }
        
        private System.DateTime? _sslCertExpiryDate;
        
        /// <summary>
        /// Optional. CS server SSL cert expiry date.
        /// </summary>
        public System.DateTime? SslCertExpiryDate
        {
            get { return this._sslCertExpiryDate; }
            set { this._sslCertExpiryDate = value; }
        }
        
        private int? _sslCertExpiryRemainingDays;
        
        /// <summary>
        /// Optional. CS server SSL cert expiry remaining says.
        /// </summary>
        public int? SslCertExpiryRemainingDays
        {
            get { return this._sslCertExpiryRemainingDays; }
            set { this._sslCertExpiryRemainingDays = value; }
        }
        
        private string _systemLoad;
        
        /// <summary>
        /// Optional. The percentage of the system load.
        /// </summary>
        public string SystemLoad
        {
            get { return this._systemLoad; }
            set { this._systemLoad = value; }
        }
        
        private string _systemLoadStatus;
        
        /// <summary>
        /// Optional. The system load status.
        /// </summary>
        public string SystemLoadStatus
        {
            get { return this._systemLoadStatus; }
            set { this._systemLoadStatus = value; }
        }
        
        private long _totalMemoryInBytes;
        
        /// <summary>
        /// Optional. The total memory.
        /// </summary>
        public long TotalMemoryInBytes
        {
            get { return this._totalMemoryInBytes; }
            set { this._totalMemoryInBytes = value; }
        }
        
        private long _totalSpaceInBytes;
        
        /// <summary>
        /// Optional. The total space.
        /// </summary>
        public long TotalSpaceInBytes
        {
            get { return this._totalSpaceInBytes; }
            set { this._totalSpaceInBytes = value; }
        }
        
        private IList<MobilityServiceUpdate> _updates;
        
        /// <summary>
        /// Optional. The list of the mobility service updates available on the
        /// Process Server.
        /// </summary>
        public IList<MobilityServiceUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }
        
        private string _versionStatus;
        
        /// <summary>
        /// Optional. Gets or sets version status
        /// </summary>
        public string VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProcessServer class.
        /// </summary>
        public ProcessServer()
        {
            this.HealthErrors = new LazyList<HealthError>();
            this.Updates = new LazyList<MobilityServiceUpdate>();
        }
    }
}
