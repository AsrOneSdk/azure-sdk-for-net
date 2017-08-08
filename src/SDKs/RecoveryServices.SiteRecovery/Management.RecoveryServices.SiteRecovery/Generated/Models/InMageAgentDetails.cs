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
    using System.Linq;

    /// <summary>
    /// The details of the InMage agent.
    /// </summary>
    public partial class InMageAgentDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageAgentDetails class.
        /// </summary>
        public InMageAgentDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageAgentDetails class.
        /// </summary>
        /// <param name="agentVersion">The agent version.</param>
        /// <param name="agentUpdateStatus">A value indicating whether
        /// installed agent needs to be updated.</param>
        /// <param name="postUpdateRebootStatus">A value indicating whether
        /// reboot is required after update is applied.</param>
        public InMageAgentDetails(string agentVersion = default(string), string agentUpdateStatus = default(string), string postUpdateRebootStatus = default(string))
        {
            AgentVersion = agentVersion;
            AgentUpdateStatus = agentUpdateStatus;
            PostUpdateRebootStatus = postUpdateRebootStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "agentUpdateStatus")]
        public string AgentUpdateStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reboot is required after
        /// update is applied.
        /// </summary>
        [JsonProperty(PropertyName = "postUpdateRebootStatus")]
        public string PostUpdateRebootStatus { get; set; }

    }
}
