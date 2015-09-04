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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of Replication protected item operations for the Site
    /// Recovery extension.
    /// </summary>
    public partial interface IReplicationProtectedItemOperations
    {
        /// <summary>
        /// Disable Protection for the given Replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Disable protection input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDisableProtectionAsync(string fabricName, string protectionContainerName, DisableProtectionInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enable Protection for the given Replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Enable protection input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginEnableProtectionAsync(string fabricName, string protectionContainerName, EnableProtectionInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Disable Protection for the given Replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Disable protection input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DisableProtectionAsync(string fabricName, string protectionContainerName, DisableProtectionInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enable Protection for the given Replication protected item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='input'>
        /// Enable protection input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> EnableProtectionAsync(string fabricName, string protectionContainerName, EnableProtectionInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the replication protected object by Id.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container unique name.
        /// </param>
        /// <param name='replicationProtectedItemName'>
        /// Replication protected item unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the fabric object
        /// </returns>
        Task<ReplicationProtectedItemResponse> GetAsync(string fabricName, string protectionContainerName, string replicationProtectedItemName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> GetDisableStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Service response for enable DR operation.
        /// </returns>
        Task<EnableProtectionResponse> GetEnableStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the replication protected object by Id.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container unique name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list replicated protected items.
        /// </returns>
        Task<ReplicationProtectedItemListResponse> ListAsync(string fabricName, string protectionContainerName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
