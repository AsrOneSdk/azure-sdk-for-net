// <auto-generated>
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            public static VCenter Get(this IReplicationvCentersOperations operations, string fabricName, string vcenterName)
            {
                return operations.GetAsync(fabricName, vcenterName).GetAwaiter().GetResult();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> GetAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, vcenterName, null, cancellationToken).ConfigureAwait(false))
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            public static VCenter Create(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, AddVCenterRequest addVCenterRequest)
            {
                return operations.CreateAsync(fabricName, vcenterName, addVCenterRequest).GetAwaiter().GetResult();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> CreateAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, AddVCenterRequest addVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, vcenterName, addVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove vcenter operation.
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            public static void Delete(this IReplicationvCentersOperations operations, string fabricName, string vcenterName)
            {
                operations.DeleteAsync(fabricName, vcenterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove vcenter operation.
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, vcenterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            public static VCenter Update(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, UpdateVCenterRequest updateVCenterRequest)
            {
                return operations.UpdateAsync(fabricName, vcenterName, updateVCenterRequest).GetAwaiter().GetResult();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> UpdateAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, UpdateVCenterRequest updateVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(fabricName, vcenterName, updateVCenterRequest, null, cancellationToken).ConfigureAwait(false))
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            public static VCenter BeginCreate(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, AddVCenterRequest addVCenterRequest)
            {
                return operations.BeginCreateAsync(fabricName, vcenterName, addVCenterRequest).GetAwaiter().GetResult();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='addVCenterRequest'>
            /// The input to the add vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> BeginCreateAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, AddVCenterRequest addVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, vcenterName, addVCenterRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove vcenter operation.
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            public static void BeginDelete(this IReplicationvCentersOperations operations, string fabricName, string vcenterName)
            {
                operations.BeginDeleteAsync(fabricName, vcenterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove vcenter operation.
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, vcenterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            public static VCenter BeginUpdate(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, UpdateVCenterRequest updateVCenterRequest)
            {
                return operations.BeginUpdateAsync(fabricName, vcenterName, updateVCenterRequest).GetAwaiter().GetResult();
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
            /// <param name='vcenterName'>
            /// vcenter name.
            /// </param>
            /// <param name='updateVCenterRequest'>
            /// The input to the update vCenter operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VCenter> BeginUpdateAsync(this IReplicationvCentersOperations operations, string fabricName, string vcenterName, UpdateVCenterRequest updateVCenterRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(fabricName, vcenterName, updateVCenterRequest, null, cancellationToken).ConfigureAwait(false))
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
