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
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public static partial class RecoveryServicesProviderOperationsExtensions
    {
        /// <summary>
        /// Refreshes a provider
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Name of provider's fabric
        /// </param>
        /// <param name='providerName'>
        /// Required. Name of provider
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginRefreshing(this IRecoveryServicesProviderOperations operations, string fabricName, string providerName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesProviderOperations)s).BeginRefreshingAsync(fabricName, providerName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Refreshes a provider
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Name of provider's fabric
        /// </param>
        /// <param name='providerName'>
        /// Required. Name of provider
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginRefreshingAsync(this IRecoveryServicesProviderOperations operations, string fabricName, string providerName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginRefreshingAsync(fabricName, providerName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the server object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='providerId'>
        /// Required. Provider ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the provider object
        /// </returns>
        public static RecoveryServicesProviderResponse Get(this IRecoveryServicesProviderOperations operations, string fabricId, string providerId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesProviderOperations)s).GetAsync(fabricId, providerId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the server object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='providerId'>
        /// Required. Provider ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the provider object
        /// </returns>
        public static Task<RecoveryServicesProviderResponse> GetAsync(this IRecoveryServicesProviderOperations operations, string fabricId, string providerId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(fabricId, providerId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse GetRefreshStatus(this IRecoveryServicesProviderOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesProviderOperations)s).GetRefreshStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> GetRefreshStatusAsync(this IRecoveryServicesProviderOperations operations, string operationStatusLink)
        {
            return operations.GetRefreshStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all servers under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list servers operation.
        /// </returns>
        public static RecoveryServicesProviderListResponse List(this IRecoveryServicesProviderOperations operations, string fabricId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesProviderOperations)s).ListAsync(fabricId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all servers under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list servers operation.
        /// </returns>
        public static Task<RecoveryServicesProviderListResponse> ListAsync(this IRecoveryServicesProviderOperations operations, string fabricId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(fabricId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Refreshes a provider
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Name of provider's fabric
        /// </param>
        /// <param name='providerName'>
        /// Required. Name of provider
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Refresh(this IRecoveryServicesProviderOperations operations, string fabricName, string providerName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesProviderOperations)s).RefreshAsync(fabricName, providerName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Refreshes a provider
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IRecoveryServicesProviderOperations.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Name of provider's fabric
        /// </param>
        /// <param name='providerName'>
        /// Required. Name of provider
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> RefreshAsync(this IRecoveryServicesProviderOperations operations, string fabricName, string providerName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.RefreshAsync(fabricName, providerName, customRequestHeaders, CancellationToken.None);
        }
    }
}
