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
    public static partial class FabricOperationsExtensions
    {
        /// <summary>
        /// Creates a Fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginCreating(this IFabricOperations operations, FabricCreationInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).BeginCreatingAsync(input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a Fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginCreatingAsync(this IFabricOperations operations, FabricCreationInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginCreatingAsync(input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a Fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to delete fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDeleting(this IFabricOperations operations, FabricDeletionInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).BeginDeletingAsync(input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a Fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to delete fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeletingAsync(this IFabricOperations operations, FabricDeletionInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginDeletingAsync(input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Create(this IFabricOperations operations, FabricCreationInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).CreateAsync(input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to create fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> CreateAsync(this IFabricOperations operations, FabricCreationInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateAsync(input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to delete fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Delete(this IFabricOperations operations, FabricDeletionInput input, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).DeleteAsync(input, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a fabric
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='input'>
        /// Required. Input to delete fabric
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> DeleteAsync(this IFabricOperations operations, FabricDeletionInput input, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteAsync(input, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the server object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the fabric object
        /// </returns>
        public static FabricResponse Get(this IFabricOperations operations, string fabricId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).GetAsync(fabricId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the server object by Id.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='fabricId'>
        /// Required. Fabric ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the fabric object
        /// </returns>
        public static Task<FabricResponse> GetAsync(this IFabricOperations operations, string fabricId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(fabricId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static CreateFabricOperationResponse GetCreateStatus(this IFabricOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).GetCreateStatusAsync(operationStatusLink);
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
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<CreateFabricOperationResponse> GetCreateStatusAsync(this IFabricOperations operations, string operationStatusLink)
        {
            return operations.GetCreateStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse GetDeleteStatus(this IFabricOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).GetDeleteStatusAsync(operationStatusLink);
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
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> GetDeleteStatusAsync(this IFabricOperations operations, string operationStatusLink)
        {
            return operations.GetDeleteStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all servers under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list servers operation.
        /// </returns>
        public static FabricListResponse List(this IFabricOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFabricOperations)s).ListAsync(customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all servers under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IFabricOperations.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list servers operation.
        /// </returns>
        public static Task<FabricListResponse> ListAsync(this IFabricOperations operations, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(customRequestHeaders, CancellationToken.None);
        }
    }
}
