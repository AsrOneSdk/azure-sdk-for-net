// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery plan custom details.
    /// </summary>
    public partial class RecoveryPlanProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class.
        /// </summary>
        public RecoveryPlanProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class.
        /// </summary>
        /// <param name="friendlyName">The friendly name.</param>
        /// <param name="primaryFabricId">The primary fabric Id.</param>
        /// <param name="primaryFabricFriendlyName">The primary fabric friendly
        /// name.</param>
        /// <param name="recoveryFabricId">The recovery fabric Id.</param>
        /// <param name="recoveryFabricFriendlyName">The recovery fabric
        /// friendly name.</param>
        /// <param name="failoverDeploymentModel">The failover deployment
        /// model.</param>
        /// <param name="replicationProviders">The list of replication
        /// providers.</param>
        /// <param name="allowedOperations">The list of allowed
        /// operations.</param>
        /// <param name="lastPlannedFailoverTime">The start time of the last
        /// planned failover.</param>
        /// <param name="lastUnplannedFailoverTime">The start time of the last
        /// unplanned failover.</param>
        /// <param name="lastTestFailoverTime">The start time of the last test
        /// failover.</param>
        /// <param name="currentScenario">The current scenario details.</param>
        /// <param name="currentScenarioStatus">The recovery plan
        /// status.</param>
        /// <param name="currentScenarioStatusDescription">The recovery plan
        /// status description.</param>
        /// <param name="groups">The recovery plan groups.</param>
        public RecoveryPlanProperties(string friendlyName = default(string), string primaryFabricId = default(string), string primaryFabricFriendlyName = default(string), string recoveryFabricId = default(string), string recoveryFabricFriendlyName = default(string), string failoverDeploymentModel = default(string), IList<string> replicationProviders = default(IList<string>), IList<string> allowedOperations = default(IList<string>), System.DateTime? lastPlannedFailoverTime = default(System.DateTime?), System.DateTime? lastUnplannedFailoverTime = default(System.DateTime?), System.DateTime? lastTestFailoverTime = default(System.DateTime?), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), string currentScenarioStatus = default(string), string currentScenarioStatusDescription = default(string), IList<RecoveryPlanGroup> groups = default(IList<RecoveryPlanGroup>))
        {
            FriendlyName = friendlyName;
            PrimaryFabricId = primaryFabricId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            RecoveryFabricId = recoveryFabricId;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            FailoverDeploymentModel = failoverDeploymentModel;
            ReplicationProviders = replicationProviders;
            AllowedOperations = allowedOperations;
            LastPlannedFailoverTime = lastPlannedFailoverTime;
            LastUnplannedFailoverTime = lastUnplannedFailoverTime;
            LastTestFailoverTime = lastTestFailoverTime;
            CurrentScenario = currentScenario;
            CurrentScenarioStatus = currentScenarioStatus;
            CurrentScenarioStatusDescription = currentScenarioStatusDescription;
            Groups = groups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the primary fabric Id.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricId")]
        public string PrimaryFabricId { get; set; }

        /// <summary>
        /// Gets or sets the primary fabric friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the failover deployment model.
        /// </summary>
        [JsonProperty(PropertyName = "failoverDeploymentModel")]
        public string FailoverDeploymentModel { get; set; }

        /// <summary>
        /// Gets or sets the list of replication providers.
        /// </summary>
        [JsonProperty(PropertyName = "replicationProviders")]
        public IList<string> ReplicationProviders { get; set; }

        /// <summary>
        /// Gets or sets the list of allowed operations.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOperations")]
        public IList<string> AllowedOperations { get; set; }

        /// <summary>
        /// Gets or sets the start time of the last planned failover.
        /// </summary>
        [JsonProperty(PropertyName = "lastPlannedFailoverTime")]
        public System.DateTime? LastPlannedFailoverTime { get; set; }

        /// <summary>
        /// Gets or sets the start time of the last unplanned failover.
        /// </summary>
        [JsonProperty(PropertyName = "lastUnplannedFailoverTime")]
        public System.DateTime? LastUnplannedFailoverTime { get; set; }

        /// <summary>
        /// Gets or sets the start time of the last test failover.
        /// </summary>
        [JsonProperty(PropertyName = "lastTestFailoverTime")]
        public System.DateTime? LastTestFailoverTime { get; set; }

        /// <summary>
        /// Gets or sets the current scenario details.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario { get; set; }

        /// <summary>
        /// Gets or sets the recovery plan status.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenarioStatus")]
        public string CurrentScenarioStatus { get; set; }

        /// <summary>
        /// Gets or sets the recovery plan status description.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenarioStatusDescription")]
        public string CurrentScenarioStatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the recovery plan groups.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<RecoveryPlanGroup> Groups { get; set; }

    }
}
