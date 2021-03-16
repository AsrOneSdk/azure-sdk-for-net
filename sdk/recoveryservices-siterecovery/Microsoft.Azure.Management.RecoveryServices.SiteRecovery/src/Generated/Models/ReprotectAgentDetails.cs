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
    /// Reprotect agent details.
    /// </summary>
    public partial class ReprotectAgentDetails
    {
        /// <summary>
        /// Initializes a new instance of the ReprotectAgentDetails class.
        /// </summary>
        public ReprotectAgentDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReprotectAgentDetails class.
        /// </summary>
        /// <param name="id">The reprotect agent Id.</param>
        /// <param name="name">The reprotect agent name.</param>
        /// <param name="biosId">The reprotect agent Bios Id.</param>
        /// <param name="fabricObjectId">The fabric object Id.</param>
        /// <param name="fqdn">The reprotect agent Fqdn.</param>
        /// <param name="version">The version.</param>
        /// <param name="lastHeartbeatUtc">The last heartbeat received from the
        /// reprotect agent.</param>
        /// <param name="health">The health of the reprotect agent. Possible
        /// values include: 'None', 'Normal', 'Warning', 'Critical'</param>
        /// <param name="healthErrors">The health errors.</param>
        public ReprotectAgentDetails(string id = default(string), string name = default(string), string biosId = default(string), string fabricObjectId = default(string), string fqdn = default(string), string version = default(string), System.DateTime? lastHeartbeatUtc = default(System.DateTime?), string health = default(string), IList<HealthError> healthErrors = default(IList<HealthError>))
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            Version = version;
            LastHeartbeatUtc = lastHeartbeatUtc;
            Health = health;
            HealthErrors = healthErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the reprotect agent Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the reprotect agent name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the reprotect agent Bios Id.
        /// </summary>
        [JsonProperty(PropertyName = "biosId")]
        public string BiosId { get; private set; }

        /// <summary>
        /// Gets the fabric object Id.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; private set; }

        /// <summary>
        /// Gets the reprotect agent Fqdn.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the last heartbeat received from the reprotect agent.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeatUtc")]
        public System.DateTime? LastHeartbeatUtc { get; private set; }

        /// <summary>
        /// Gets the health of the reprotect agent. Possible values include:
        /// 'None', 'Normal', 'Warning', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public string Health { get; private set; }

        /// <summary>
        /// Gets the health errors.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; private set; }

    }
}
