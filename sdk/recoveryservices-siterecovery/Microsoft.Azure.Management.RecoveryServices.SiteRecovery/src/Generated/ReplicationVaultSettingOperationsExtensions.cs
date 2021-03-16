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
    /// Extension methods for ReplicationVaultSettingOperations.
    /// </summary>
    public static partial class ReplicationVaultSettingOperationsExtensions
    {
            /// <summary>
            /// Gets the list of vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the list of vault setting. This includes the Migration Hub connection
            /// settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VaultSetting> List(this IReplicationVaultSettingOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the list of vault setting. This includes the Migration Hub connection
            /// settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VaultSetting>> ListAsync(this IReplicationVaultSettingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the vault setting. This includes the Migration Hub connection
            /// settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            public static VaultSetting Get(this IReplicationVaultSettingOperations operations, string vaultSettingName)
            {
                return operations.GetAsync(vaultSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the vault setting. This includes the Migration Hub connection
            /// settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultSetting> GetAsync(this IReplicationVaultSettingOperations operations, string vaultSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultSettingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates vault setting. A vault setting object is a singleton per vault and
            /// it is always present by default.
            /// </summary>
            /// <remarks>
            /// The operation to configure vault setting.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            /// <param name='input'>
            /// Vault setting creation input.
            /// </param>
            public static VaultSetting Create(this IReplicationVaultSettingOperations operations, string vaultSettingName, VaultSettingCreationInput input)
            {
                return operations.CreateAsync(vaultSettingName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates vault setting. A vault setting object is a singleton per vault and
            /// it is always present by default.
            /// </summary>
            /// <remarks>
            /// The operation to configure vault setting.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            /// <param name='input'>
            /// Vault setting creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultSetting> CreateAsync(this IReplicationVaultSettingOperations operations, string vaultSettingName, VaultSettingCreationInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(vaultSettingName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates vault setting. A vault setting object is a singleton per vault and
            /// it is always present by default.
            /// </summary>
            /// <remarks>
            /// The operation to configure vault setting.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            /// <param name='input'>
            /// Vault setting creation input.
            /// </param>
            public static VaultSetting BeginCreate(this IReplicationVaultSettingOperations operations, string vaultSettingName, VaultSettingCreationInput input)
            {
                return operations.BeginCreateAsync(vaultSettingName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates vault setting. A vault setting object is a singleton per vault and
            /// it is always present by default.
            /// </summary>
            /// <remarks>
            /// The operation to configure vault setting.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultSettingName'>
            /// Vault setting name.
            /// </param>
            /// <param name='input'>
            /// Vault setting creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultSetting> BeginCreateAsync(this IReplicationVaultSettingOperations operations, string vaultSettingName, VaultSettingCreationInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(vaultSettingName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the list of vault setting. This includes the Migration Hub connection
            /// settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VaultSetting> ListNext(this IReplicationVaultSettingOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of vault setting.
            /// </summary>
            /// <remarks>
            /// Gets the list of vault setting. This includes the Migration Hub connection
            /// settings.
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
            public static async Task<IPage<VaultSetting>> ListNextAsync(this IReplicationVaultSettingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
