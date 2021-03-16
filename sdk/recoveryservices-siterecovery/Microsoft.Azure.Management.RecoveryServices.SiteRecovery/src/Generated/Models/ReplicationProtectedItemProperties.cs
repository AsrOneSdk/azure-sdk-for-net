// <auto-generated>
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
    /// Replication protected item custom data details.
    /// </summary>
    public partial class ReplicationProtectedItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        /// <param name="friendlyName">The name.</param>
        /// <param name="protectedItemType">The type of protected item
        /// type.</param>
        /// <param name="protectableItemId">The protected item ARM Id.</param>
        /// <param name="recoveryServicesProviderId">The recovery provider ARM
        /// Id.</param>
        /// <param name="primaryFabricFriendlyName">The friendly name of the
        /// primary fabric.</param>
        /// <param name="primaryFabricProvider">The fabric provider of the
        /// primary fabric.</param>
        /// <param name="recoveryFabricFriendlyName">The friendly name of
        /// recovery fabric.</param>
        /// <param name="recoveryFabricId">The Arm Id of recovery
        /// fabric.</param>
        /// <param name="primaryProtectionContainerFriendlyName">The name of
        /// primary protection container friendly name.</param>
        /// <param name="recoveryProtectionContainerFriendlyName">The name of
        /// recovery container friendly name.</param>
        /// <param name="protectionState">The protection status.</param>
        /// <param name="protectionStateDescription">The protection state
        /// description.</param>
        /// <param name="activeLocation">The Current active location of the
        /// PE.</param>
        /// <param name="testFailoverState">The Test failover state.</param>
        /// <param name="testFailoverStateDescription">The Test failover state
        /// description.</param>
        /// <param name="allowedOperations">The allowed operations on the
        /// Replication protected item.</param>
        /// <param name="replicationHealth">The consolidated protection health
        /// for the VM taking any issues with SRS as well as all the
        /// replication units associated with the VM's replication group into
        /// account. This is a string representation of the ProtectionHealth
        /// enumeration.</param>
        /// <param name="failoverHealth">The consolidated failover health for
        /// the VM.</param>
        /// <param name="healthErrors">List of health errors.</param>
        /// <param name="policyId">The ID of Policy governing this PE.</param>
        /// <param name="policyFriendlyName">The name of Policy governing this
        /// PE.</param>
        /// <param name="lastSuccessfulFailoverTime">The Last successful
        /// failover time.</param>
        /// <param name="lastSuccessfulTestFailoverTime">The Last successful
        /// test failover time.</param>
        /// <param name="currentScenario">The current scenario.</param>
        /// <param name="failoverRecoveryPointId">The recovery point ARM Id to
        /// which the Vm was failed over.</param>
        /// <param name="providerSpecificDetails">The Replication provider
        /// custom settings.</param>
        /// <param name="recoveryContainerId">The recovery container
        /// Id.</param>
        /// <param name="eventCorrelationId">The correlation Id for events
        /// associated with this protected item.</param>
        public ReplicationProtectedItemProperties(string friendlyName = default(string), string protectedItemType = default(string), string protectableItemId = default(string), string recoveryServicesProviderId = default(string), string primaryFabricFriendlyName = default(string), string primaryFabricProvider = default(string), string recoveryFabricFriendlyName = default(string), string recoveryFabricId = default(string), string primaryProtectionContainerFriendlyName = default(string), string recoveryProtectionContainerFriendlyName = default(string), string protectionState = default(string), string protectionStateDescription = default(string), string activeLocation = default(string), string testFailoverState = default(string), string testFailoverStateDescription = default(string), IList<string> allowedOperations = default(IList<string>), string replicationHealth = default(string), string failoverHealth = default(string), IList<HealthError> healthErrors = default(IList<HealthError>), string policyId = default(string), string policyFriendlyName = default(string), System.DateTime? lastSuccessfulFailoverTime = default(System.DateTime?), System.DateTime? lastSuccessfulTestFailoverTime = default(System.DateTime?), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), string failoverRecoveryPointId = default(string), ReplicationProviderSpecificSettings providerSpecificDetails = default(ReplicationProviderSpecificSettings), string recoveryContainerId = default(string), string eventCorrelationId = default(string))
        {
            FriendlyName = friendlyName;
            ProtectedItemType = protectedItemType;
            ProtectableItemId = protectableItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            PrimaryFabricProvider = primaryFabricProvider;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            RecoveryFabricId = recoveryFabricId;
            PrimaryProtectionContainerFriendlyName = primaryProtectionContainerFriendlyName;
            RecoveryProtectionContainerFriendlyName = recoveryProtectionContainerFriendlyName;
            ProtectionState = protectionState;
            ProtectionStateDescription = protectionStateDescription;
            ActiveLocation = activeLocation;
            TestFailoverState = testFailoverState;
            TestFailoverStateDescription = testFailoverStateDescription;
            AllowedOperations = allowedOperations;
            ReplicationHealth = replicationHealth;
            FailoverHealth = failoverHealth;
            HealthErrors = healthErrors;
            PolicyId = policyId;
            PolicyFriendlyName = policyFriendlyName;
            LastSuccessfulFailoverTime = lastSuccessfulFailoverTime;
            LastSuccessfulTestFailoverTime = lastSuccessfulTestFailoverTime;
            CurrentScenario = currentScenario;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
            RecoveryContainerId = recoveryContainerId;
            EventCorrelationId = eventCorrelationId;
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
        /// Gets or sets the type of protected item type.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemType")]
        public string ProtectedItemType { get; set; }

        /// <summary>
        /// Gets or sets the protected item ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "protectableItemId")]
        public string ProtectableItemId { get; set; }

        /// <summary>
        /// Gets or sets the recovery provider ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the primary fabric.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the fabric provider of the primary fabric.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricProvider")]
        public string PrimaryFabricProvider { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of recovery fabric.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the Arm Id of recovery fabric.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId { get; set; }

        /// <summary>
        /// Gets or sets the name of primary protection container friendly
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "primaryProtectionContainerFriendlyName")]
        public string PrimaryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the name of recovery container friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProtectionContainerFriendlyName")]
        public string RecoveryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the protection status.
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStateDescription")]
        public string ProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the Current active location of the PE.
        /// </summary>
        [JsonProperty(PropertyName = "activeLocation")]
        public string ActiveLocation { get; set; }

        /// <summary>
        /// Gets or sets the Test failover state.
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverState")]
        public string TestFailoverState { get; set; }

        /// <summary>
        /// Gets or sets the Test failover state description.
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverStateDescription")]
        public string TestFailoverStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the allowed operations on the Replication protected
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOperations")]
        public IList<string> AllowedOperations { get; set; }

        /// <summary>
        /// Gets or sets the consolidated protection health for the VM taking
        /// any issues with SRS as well as all the replication units associated
        /// with the VM's replication group into account. This is a string
        /// representation of the ProtectionHealth enumeration.
        /// </summary>
        [JsonProperty(PropertyName = "replicationHealth")]
        public string ReplicationHealth { get; set; }

        /// <summary>
        /// Gets or sets the consolidated failover health for the VM.
        /// </summary>
        [JsonProperty(PropertyName = "failoverHealth")]
        public string FailoverHealth { get; set; }

        /// <summary>
        /// Gets or sets list of health errors.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; set; }

        /// <summary>
        /// Gets or sets the ID of Policy governing this PE.
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or sets the name of Policy governing this PE.
        /// </summary>
        [JsonProperty(PropertyName = "policyFriendlyName")]
        public string PolicyFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the Last successful failover time.
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulFailoverTime")]
        public System.DateTime? LastSuccessfulFailoverTime { get; set; }

        /// <summary>
        /// Gets or sets the Last successful test failover time.
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulTestFailoverTime")]
        public System.DateTime? LastSuccessfulTestFailoverTime { get; set; }

        /// <summary>
        /// Gets or sets the current scenario.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario { get; set; }

        /// <summary>
        /// Gets or sets the recovery point ARM Id to which the Vm was failed
        /// over.
        /// </summary>
        [JsonProperty(PropertyName = "failoverRecoveryPointId")]
        public string FailoverRecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets the Replication provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ReplicationProviderSpecificSettings ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Gets or sets the recovery container Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId { get; set; }

        /// <summary>
        /// Gets or sets the correlation Id for events associated with this
        /// protected item.
        /// </summary>
        [JsonProperty(PropertyName = "eventCorrelationId")]
        public string EventCorrelationId { get; set; }

    }
}
