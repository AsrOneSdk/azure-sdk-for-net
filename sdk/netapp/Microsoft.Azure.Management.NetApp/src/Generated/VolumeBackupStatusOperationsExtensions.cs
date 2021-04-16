// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VolumeBackupStatusOperations.
    /// </summary>
    public static partial class VolumeBackupStatusOperationsExtensions
    {
            /// <summary>
            /// Get volume's backup status
            /// </summary>
            /// <remarks>
            /// Get the status of the backup for a volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            public static BackupStatus Get(this IVolumeBackupStatusOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName)
            {
                return operations.GetAsync(resourceGroupName, accountName, poolName, volumeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get volume's backup status
            /// </summary>
            /// <remarks>
            /// Get the status of the backup for a volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupStatus> GetAsync(this IVolumeBackupStatusOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
