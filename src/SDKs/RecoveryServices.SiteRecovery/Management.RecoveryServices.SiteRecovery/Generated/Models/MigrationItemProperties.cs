// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Migration item properties.
    /// </summary>
    public partial class MigrationItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the MigrationItemProperties class.
        /// </summary>
        public MigrationItemProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationItemProperties class.
        /// </summary>
        /// <param name="friendlyName">The name.</param>
        /// <param name="policyId">The ARM Id of policy governing this
        /// item.</param>
        /// <param name="policyFriendlyName">The name of policy governing this
        /// item.</param>
        /// <param name="recoveryServicesProviderId">The recovery services
        /// provider ARM Id.</param>
        /// <param name="migrationState">The migration status.</param>
        /// <param name="migrationStateDescription">The migration state
        /// description.</param>
        /// <param name="testMigrateState">The test migrate state.</param>
        /// <param name="testMigrateStateDescription">The test migrate state
        /// description.</param>
        /// <param name="allowedOperations">The allowed operations on the
        /// migration item.</param>
        /// <param name="currentScenario">The current scenario.</param>
        /// <param name="providerSpecificDetails">The migration provider custom
        /// settings.</param>
        public MigrationItemProperties(string friendlyName = default(string), string policyId = default(string), string policyFriendlyName = default(string), string recoveryServicesProviderId = default(string), string migrationState = default(string), string migrationStateDescription = default(string), string testMigrateState = default(string), string testMigrateStateDescription = default(string), IList<string> allowedOperations = default(IList<string>), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), MigrationProviderSpecificSettings providerSpecificDetails = default(MigrationProviderSpecificSettings))
        {
            FriendlyName = friendlyName;
            PolicyId = policyId;
            PolicyFriendlyName = policyFriendlyName;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            MigrationState = migrationState;
            MigrationStateDescription = migrationStateDescription;
            TestMigrateState = testMigrateState;
            TestMigrateStateDescription = testMigrateStateDescription;
            AllowedOperations = allowedOperations;
            CurrentScenario = currentScenario;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of policy governing this item.
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or sets the name of policy governing this item.
        /// </summary>
        [JsonProperty(PropertyName = "policyFriendlyName")]
        public string PolicyFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the recovery services provider ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// Gets or sets the migration status.
        /// </summary>
        [JsonProperty(PropertyName = "migrationState")]
        public string MigrationState { get; set; }

        /// <summary>
        /// Gets or sets the migration state description.
        /// </summary>
        [JsonProperty(PropertyName = "migrationStateDescription")]
        public string MigrationStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the test migrate state.
        /// </summary>
        [JsonProperty(PropertyName = "testMigrateState")]
        public string TestMigrateState { get; set; }

        /// <summary>
        /// Gets or sets the test migrate state description.
        /// </summary>
        [JsonProperty(PropertyName = "testMigrateStateDescription")]
        public string TestMigrateStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the allowed operations on the migration item.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOperations")]
        public IList<string> AllowedOperations { get; set; }

        /// <summary>
        /// Gets or sets the current scenario.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario { get; set; }

        /// <summary>
        /// Gets or sets the migration provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public MigrationProviderSpecificSettings ProviderSpecificDetails { get; set; }

    }
}
