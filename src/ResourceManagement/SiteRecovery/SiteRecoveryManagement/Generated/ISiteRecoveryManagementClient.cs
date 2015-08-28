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
using Microsoft.Azure;
using Microsoft.Azure.Management.SiteRecovery;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public partial interface ISiteRecoveryManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        string ResourceGroupName
        {
            get; set; 
        }
        
        string ResourceName
        {
            get; set; 
        }
        
        string ResourceNamespace
        {
            get; set; 
        }
        
        /// <summary>
        /// Definition for Job Operations.
        /// </summary>
        IJobOperations Jobs
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Protection Container operations for the Site Recovery
        /// extension.
        /// </summary>
        IProtectionContainerOperations ProtectionContainer
        {
            get; 
        }
        
        /// <summary>
        /// Definition of protection entity operations for the Site Recovery
        /// extension.
        /// </summary>
        IProtectionEntityOperations ProtectionEntity
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Protection Profile operations for the Site Recovery
        /// extension.
        /// </summary>
        IProtectionProfileOperations ProtectionProfile
        {
            get; 
        }
        
        /// <summary>
        /// Definition of recoveryplan operations for the Site Recovery
        /// extension.
        /// </summary>
        IRecoveryPlanOperations RecoveryPlan
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Replication protected item operations for the Site
        /// Recovery extension.
        /// </summary>
        IReplicationProtectedItemOperations ReplicationProtectedItem
        {
            get; 
        }
        
        /// <summary>
        /// Definition of server operations for the Site Recovery extension.
        /// </summary>
        IServerOperations Servers
        {
            get; 
        }
    }
}
