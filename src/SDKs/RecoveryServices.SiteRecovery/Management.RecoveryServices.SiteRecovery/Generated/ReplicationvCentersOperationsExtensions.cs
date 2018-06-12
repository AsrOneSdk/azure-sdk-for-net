// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationvCentersOperations.
    /// </summary>
    public static partial class ReplicationvCentersOperationsExtensions
    {
            /// <summary>
            /// Gets the list of vCenter registered under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in a fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            public static IPage<VCenter> ListByReplicationFabrics(this IReplicationvCentersOperations operations, string fabricName)
            {
                return operations.ListByReplicationFabricsAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vCenter registered under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in a fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VCenter>> ListByReplicationFabricsAsync(this IReplicationvCentersOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of a vCenter.
            /// </summary>
            /// <remarks>
            /// Gets the details of a registered vCenter server(Add vCenter server).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            public static VCenter Get(this IReplicationvCentersOperations operations, string fabricName, string vCenterName)
            {
                return operations.GetAsync(fabricName, vCenterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a vCenter.
            /// </summary>
            /// <remarks>
            /// Gets the details of a registered vCenter server(Add vCenter server).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> GetAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, vCenterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add vCenter.
            /// </summary>
            /// <remarks>
            /// The operation to create a vCenter object..
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            public static VCenter Create(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, AddVCenterRequest addVCenterRequest)
            {
                return operations.CreateAsync(fabricName, vCenterName, addVCenterRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add vCenter.
            /// </summary>
            /// <remarks>
            /// The operation to create a vCenter object..
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> CreateAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, AddVCenterRequest addVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, vCenterName, addVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to remove(unregister) a registered vCenter server from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            public static void Delete(this IReplicationvCentersOperations operations, string fabricName, string vCenterName)
            {
                operations.DeleteAsync(fabricName, vCenterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to remove(unregister) a registered vCenter server from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, vCenterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to update a registered vCenter.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCeneter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            public static VCenter Update(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, UpdateVCenterRequest updateVCenterRequest)
            {
                return operations.UpdateAsync(fabricName, vCenterName, updateVCenterRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to update a registered vCenter.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCeneter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> UpdateAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, UpdateVCenterRequest updateVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(fabricName, vCenterName, updateVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of vCenter registered under the vault.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VCenter> List(this IReplicationvCentersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vCenter registered under the vault.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VCenter>> ListAsync(this IReplicationvCentersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add vCenter.
            /// </summary>
            /// <remarks>
            /// The operation to create a vCenter object..
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            public static VCenter BeginCreate(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, AddVCenterRequest addVCenterRequest)
            {
                return operations.BeginCreateAsync(fabricName, vCenterName, addVCenterRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add vCenter.
            /// </summary>
            /// <remarks>
            /// The operation to create a vCenter object..
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> BeginCreateAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, AddVCenterRequest addVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, vCenterName, addVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to remove(unregister) a registered vCenter server from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            public static void BeginDelete(this IReplicationvCentersOperations operations, string fabricName, string vCenterName)
            {
                operations.BeginDeleteAsync(fabricName, vCenterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to remove(unregister) a registered vCenter server from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, vCenterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to update a registered vCenter.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCeneter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            public static VCenter BeginUpdate(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, UpdateVCenterRequest updateVCenterRequest)
            {
                return operations.BeginUpdateAsync(fabricName, vCenterName, updateVCenterRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update vCenter operation.
            /// </summary>
            /// <remarks>
            /// The operation to update a registered vCenter.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='vCenterName'>
            /// vCeneter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> BeginUpdateAsync(this IReplicationvCentersOperations operations, string fabricName, string vCenterName, UpdateVCenterRequest updateVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(fabricName, vCenterName, updateVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of vCenter registered under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in a fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VCenter> ListByReplicationFabricsNext(this IReplicationvCentersOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationFabricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vCenter registered under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in a fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VCenter>> ListByReplicationFabricsNextAsync(this IReplicationvCentersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of vCenter registered under the vault.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VCenter> ListNext(this IReplicationvCentersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vCenter registered under the vault.
            /// </summary>
            /// <remarks>
            /// Lists the vCenter servers registered in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VCenter>> ListNextAsync(this IReplicationvCentersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
