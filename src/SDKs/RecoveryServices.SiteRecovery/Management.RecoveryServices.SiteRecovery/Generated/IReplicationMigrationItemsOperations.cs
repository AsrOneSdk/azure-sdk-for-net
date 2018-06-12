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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReplicationMigrationItemsOperations operations.
    /// </summary>
    public partial interface IReplicationMigrationItemsOperations
    {
        /// <summary>
        /// Gets the list of migration items in the protection container.
        /// </summary>
        /// <remarks>
        /// Gets the list of ASR migration items in the protection container.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MigrationItem>>> ListByReplicationProtectionContainersWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of a migration item.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric unique name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MigrationItem>> GetWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables migration.
        /// </summary>
        /// <remarks>
        /// The operation to create an ASR migration item (enable migration).
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='input'>
        /// Enable migration input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MigrationItem>> CreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, EnableMigrationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges migration.
        /// </summary>
        /// <remarks>
        /// The operation to purge an ASR migration item. This operation will
        /// force delete the migration item. Use the remove operation on
        /// migration item to perform a clean disable migration for the item.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PurgeWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables migration.
        /// </summary>
        /// <remarks>
        /// The operation to disable an ASR migration item.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of migration items in the vault.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='skipToken'>
        /// The pagination token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MigrationItem>>> ListWithHttpMessagesAsync(ODataQuery<MigrationItemsQueryParameter> odataQuery = default(ODataQuery<MigrationItemsQueryParameter>), string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables migration.
        /// </summary>
        /// <remarks>
        /// The operation to create an ASR migration item (enable migration).
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='input'>
        /// Enable migration input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MigrationItem>> BeginCreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, EnableMigrationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges migration.
        /// </summary>
        /// <remarks>
        /// The operation to purge an ASR migration item. This operation will
        /// force delete the migration item. Use the remove operation on
        /// migration item to perform a clean disable migration for the item.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginPurgeWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables migration.
        /// </summary>
        /// <remarks>
        /// The operation to disable an ASR migration item.
        /// </remarks>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='migrationItemName'>
        /// Migration item name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, string migrationItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of migration items in the protection container.
        /// </summary>
        /// <remarks>
        /// Gets the list of ASR migration items in the protection container.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MigrationItem>>> ListByReplicationProtectionContainersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of migration items in the vault.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MigrationItem>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
