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
    /// The details of the InMage agent.
    /// </summary>
    public partial class InMageAgentDetails
    {
        private System.DateTime? _agentExpiryDate;
        
        /// <summary>
        /// Optional. Agent expiry date.
        /// </summary>
        public System.DateTime? AgentExpiryDate
        {
            get { return this._agentExpiryDate; }
            set { this._agentExpiryDate = value; }
        }
        
        private string _agentUpdateStatus;
        
        /// <summary>
        /// Optional. Indicates whether installed agent needs to be updated.
        /// </summary>
        public string AgentUpdateStatus
        {
            get { return this._agentUpdateStatus; }
            set { this._agentUpdateStatus = value; }
        }
        
        private string _agentVersion;
        
        /// <summary>
        /// Optional. The agent version.
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }
        
        private string _postUpdateRebootStatus;
        
        /// <summary>
        /// Optional. Indicates whether reboot is required after update is
        /// applied.
        /// </summary>
        public string PostUpdateRebootStatus
        {
            get { return this._postUpdateRebootStatus; }
            set { this._postUpdateRebootStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InMageAgentDetails class.
        /// </summary>
        public InMageAgentDetails()
        {
        }
    }
}
