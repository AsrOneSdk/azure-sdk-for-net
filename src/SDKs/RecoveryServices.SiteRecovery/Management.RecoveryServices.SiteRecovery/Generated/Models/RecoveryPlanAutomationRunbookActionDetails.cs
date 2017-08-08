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
    /// Recovery plan Automation runbook action details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AutomationRunbookActionDetails")]
    public partial class RecoveryPlanAutomationRunbookActionDetails : RecoveryPlanActionDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanAutomationRunbookActionDetails class.
        /// </summary>
        public RecoveryPlanAutomationRunbookActionDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanAutomationRunbookActionDetails class.
        /// </summary>
        /// <param name="fabricLocation">The fabric location. Possible values
        /// include: 'Primary', 'Recovery'</param>
        /// <param name="runbookId">The runbook ARM Id.</param>
        /// <param name="timeout">The runbook timeout.</param>
        public RecoveryPlanAutomationRunbookActionDetails(RecoveryPlanActionLocation fabricLocation, string runbookId = default(string), string timeout = default(string))
        {
            RunbookId = runbookId;
            Timeout = timeout;
            FabricLocation = fabricLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the runbook ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }

        /// <summary>
        /// Gets or sets the runbook timeout.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or sets the fabric location. Possible values include:
        /// 'Primary', 'Recovery'
        /// </summary>
        [JsonProperty(PropertyName = "fabricLocation")]
        public RecoveryPlanActionLocation FabricLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
