// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationStorageClassificationsOperations.
    /// </summary>
    public static partial class ReplicationStorageClassificationsOperationsExtensions
    {
            /// <summary>
            /// Gets the details of a storage classification.
            /// </summary>
            /// <remarks>
            /// Gets the details of the specified storage classification.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            public static StorageClassification Get(this IReplicationStorageClassificationsOperations operations, string fabricName, string storageClassificationName)
            {
                return operations.GetAsync(fabricName, storageClassificationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a storage classification.
            /// </summary>
            /// <remarks>
            /// Gets the details of the specified storage classification.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageClassification> GetAsync(this IReplicationStorageClassificationsOperations operations, string fabricName, string storageClassificationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, storageClassificationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications available in the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            public static IPage<StorageClassification> ListByReplicationFabrics(this IReplicationStorageClassificationsOperations operations, string fabricName)
            {
                return operations.ListByReplicationFabricsAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications available in the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListByReplicationFabricsAsync(this IReplicationStorageClassificationsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<StorageClassification> List(this IReplicationStorageClassificationsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListAsync(this IReplicationStorageClassificationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications available in the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassification> ListByReplicationFabricsNext(this IReplicationStorageClassificationsOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationFabricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications available in the specified fabric.
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
            public static async Task<IPage<StorageClassification>> ListByReplicationFabricsNextAsync(this IReplicationStorageClassificationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassification> ListNext(this IReplicationStorageClassificationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classifications in the vault.
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
            public static async Task<IPage<StorageClassification>> ListNextAsync(this IReplicationStorageClassificationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
