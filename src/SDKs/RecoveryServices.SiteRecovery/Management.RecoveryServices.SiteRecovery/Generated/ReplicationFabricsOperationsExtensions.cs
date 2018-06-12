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
    /// Extension methods for ReplicationFabricsOperations.
    /// </summary>
    public static partial class ReplicationFabricsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of ASR fabrics.
            /// </summary>
            /// <remarks>
            /// Gets a list of the Azure Site Recovery fabrics in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Fabric> List(this IReplicationFabricsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of ASR fabrics.
            /// </summary>
            /// <remarks>
            /// Gets a list of the Azure Site Recovery fabrics in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Fabric>> ListAsync(this IReplicationFabricsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of an ASR fabric.
            /// </summary>
            /// <remarks>
            /// Gets the details of an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            public static Fabric Get(this IReplicationFabricsOperations operations, string fabricName)
            {
                return operations.GetAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of an ASR fabric.
            /// </summary>
            /// <remarks>
            /// Gets the details of an Azure Site Recovery fabric.
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
            public static async Task<Fabric> GetAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Azure Site Recovery fabric.
            /// </summary>
            /// <remarks>
            /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V
            /// site).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the ASR fabric.
            /// </param>
            /// <param name='input'>
            /// Fabric creation input.
            /// </param>
            public static Fabric Create(this IReplicationFabricsOperations operations, string fabricName, FabricCreationInput input)
            {
                return operations.CreateAsync(fabricName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure Site Recovery fabric.
            /// </summary>
            /// <remarks>
            /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V
            /// site).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the ASR fabric.
            /// </param>
            /// <param name='input'>
            /// Fabric creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> CreateAsync(this IReplicationFabricsOperations operations, string fabricName, FabricCreationInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purges the site.
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to purge.
            /// </param>
            public static void Purge(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.PurgeAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges the site.
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to purge.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks the consistency of the ASR fabric.
            /// </summary>
            /// <remarks>
            /// The operation to perform a consistency check on the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            public static Fabric CheckConsistency(this IReplicationFabricsOperations operations, string fabricName)
            {
                return operations.CheckConsistencyAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the consistency of the ASR fabric.
            /// </summary>
            /// <remarks>
            /// The operation to perform a consistency check on the fabric.
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
            public static async Task<Fabric> CheckConsistencyAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckConsistencyWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Migrates the site to AAD.
            /// </summary>
            /// <remarks>
            /// The operation to migrate an Azure Site Recovery fabric to AAD.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to migrate.
            /// </param>
            public static void MigrateToAad(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.MigrateToAadAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Migrates the site to AAD.
            /// </summary>
            /// <remarks>
            /// The operation to migrate an Azure Site Recovery fabric to AAD.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to migrate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MigrateToAadAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MigrateToAadWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Perform failover of the process server.
            /// </summary>
            /// <remarks>
            /// The operation to move replications from a process server to another process
            /// server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric containing the process server.
            /// </param>
            /// <param name='failoverProcessServerRequest'>
            /// The input to the failover process server operation.
            /// </param>
            public static Fabric ReassociateGateway(this IReplicationFabricsOperations operations, string fabricName, FailoverProcessServerRequest failoverProcessServerRequest)
            {
                return operations.ReassociateGatewayAsync(fabricName, failoverProcessServerRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Perform failover of the process server.
            /// </summary>
            /// <remarks>
            /// The operation to move replications from a process server to another process
            /// server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric containing the process server.
            /// </param>
            /// <param name='failoverProcessServerRequest'>
            /// The input to the failover process server operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> ReassociateGatewayAsync(this IReplicationFabricsOperations operations, string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReassociateGatewayWithHttpMessagesAsync(fabricName, failoverProcessServerRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the site.
            /// </summary>
            /// <remarks>
            /// The operation to delete or remove an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to delete.
            /// </param>
            public static void Delete(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.DeleteAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the site.
            /// </summary>
            /// <remarks>
            /// The operation to delete or remove an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Renews certificate for the fabric.
            /// </summary>
            /// <remarks>
            /// Renews the connection certificate for the ASR replication fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// fabric name to renew certs for.
            /// </param>
            /// <param name='renewCertificate'>
            /// Renew certificate input.
            /// </param>
            public static Fabric RenewCertificate(this IReplicationFabricsOperations operations, string fabricName, RenewCertificateInput renewCertificate)
            {
                return operations.RenewCertificateAsync(fabricName, renewCertificate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Renews certificate for the fabric.
            /// </summary>
            /// <remarks>
            /// Renews the connection certificate for the ASR replication fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// fabric name to renew certs for.
            /// </param>
            /// <param name='renewCertificate'>
            /// Renew certificate input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> RenewCertificateAsync(this IReplicationFabricsOperations operations, string fabricName, RenewCertificateInput renewCertificate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RenewCertificateWithHttpMessagesAsync(fabricName, renewCertificate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Azure Site Recovery fabric.
            /// </summary>
            /// <remarks>
            /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V
            /// site).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the ASR fabric.
            /// </param>
            /// <param name='input'>
            /// Fabric creation input.
            /// </param>
            public static Fabric BeginCreate(this IReplicationFabricsOperations operations, string fabricName, FabricCreationInput input)
            {
                return operations.BeginCreateAsync(fabricName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure Site Recovery fabric.
            /// </summary>
            /// <remarks>
            /// The operation to create an Azure Site Recovery fabric (for e.g. Hyper-V
            /// site).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the ASR fabric.
            /// </param>
            /// <param name='input'>
            /// Fabric creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> BeginCreateAsync(this IReplicationFabricsOperations operations, string fabricName, FabricCreationInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purges the site.
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to purge.
            /// </param>
            public static void BeginPurge(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.BeginPurgeAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges the site.
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to purge.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks the consistency of the ASR fabric.
            /// </summary>
            /// <remarks>
            /// The operation to perform a consistency check on the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            public static Fabric BeginCheckConsistency(this IReplicationFabricsOperations operations, string fabricName)
            {
                return operations.BeginCheckConsistencyAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the consistency of the ASR fabric.
            /// </summary>
            /// <remarks>
            /// The operation to perform a consistency check on the fabric.
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
            public static async Task<Fabric> BeginCheckConsistencyAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCheckConsistencyWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Migrates the site to AAD.
            /// </summary>
            /// <remarks>
            /// The operation to migrate an Azure Site Recovery fabric to AAD.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to migrate.
            /// </param>
            public static void BeginMigrateToAad(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.BeginMigrateToAadAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Migrates the site to AAD.
            /// </summary>
            /// <remarks>
            /// The operation to migrate an Azure Site Recovery fabric to AAD.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to migrate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginMigrateToAadAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginMigrateToAadWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Perform failover of the process server.
            /// </summary>
            /// <remarks>
            /// The operation to move replications from a process server to another process
            /// server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric containing the process server.
            /// </param>
            /// <param name='failoverProcessServerRequest'>
            /// The input to the failover process server operation.
            /// </param>
            public static Fabric BeginReassociateGateway(this IReplicationFabricsOperations operations, string fabricName, FailoverProcessServerRequest failoverProcessServerRequest)
            {
                return operations.BeginReassociateGatewayAsync(fabricName, failoverProcessServerRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Perform failover of the process server.
            /// </summary>
            /// <remarks>
            /// The operation to move replications from a process server to another process
            /// server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric containing the process server.
            /// </param>
            /// <param name='failoverProcessServerRequest'>
            /// The input to the failover process server operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> BeginReassociateGatewayAsync(this IReplicationFabricsOperations operations, string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginReassociateGatewayWithHttpMessagesAsync(fabricName, failoverProcessServerRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the site.
            /// </summary>
            /// <remarks>
            /// The operation to delete or remove an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to delete.
            /// </param>
            public static void BeginDelete(this IReplicationFabricsOperations operations, string fabricName)
            {
                operations.BeginDeleteAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the site.
            /// </summary>
            /// <remarks>
            /// The operation to delete or remove an Azure Site Recovery fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// ASR fabric to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationFabricsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Renews certificate for the fabric.
            /// </summary>
            /// <remarks>
            /// Renews the connection certificate for the ASR replication fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// fabric name to renew certs for.
            /// </param>
            /// <param name='renewCertificate'>
            /// Renew certificate input.
            /// </param>
            public static Fabric BeginRenewCertificate(this IReplicationFabricsOperations operations, string fabricName, RenewCertificateInput renewCertificate)
            {
                return operations.BeginRenewCertificateAsync(fabricName, renewCertificate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Renews certificate for the fabric.
            /// </summary>
            /// <remarks>
            /// Renews the connection certificate for the ASR replication fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// fabric name to renew certs for.
            /// </param>
            /// <param name='renewCertificate'>
            /// Renew certificate input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> BeginRenewCertificateAsync(this IReplicationFabricsOperations operations, string fabricName, RenewCertificateInput renewCertificate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRenewCertificateWithHttpMessagesAsync(fabricName, renewCertificate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of ASR fabrics.
            /// </summary>
            /// <remarks>
            /// Gets a list of the Azure Site Recovery fabrics in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Fabric> ListNext(this IReplicationFabricsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of ASR fabrics.
            /// </summary>
            /// <remarks>
            /// Gets a list of the Azure Site Recovery fabrics in the vault.
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
            public static async Task<IPage<Fabric>> ListNextAsync(this IReplicationFabricsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
