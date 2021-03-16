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
    /// The properties of the Failover Process Server request.
    /// </summary>
    public partial class FailoverProcessServerRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FailoverProcessServerRequestProperties class.
        /// </summary>
        public FailoverProcessServerRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FailoverProcessServerRequestProperties class.
        /// </summary>
        /// <param name="containerName">The container identifier.</param>
        /// <param name="sourceProcessServerId">The source process
        /// server.</param>
        /// <param name="targetProcessServerId">The new process server.</param>
        /// <param name="vmsToMigrate">The VMS to migrate.</param>
        /// <param name="updateType">A value for failover type. It can be
        /// systemlevel/serverlevel.</param>
        public FailoverProcessServerRequestProperties(string containerName = default(string), string sourceProcessServerId = default(string), string targetProcessServerId = default(string), IList<string> vmsToMigrate = default(IList<string>), string updateType = default(string))
        {
            ContainerName = containerName;
            SourceProcessServerId = sourceProcessServerId;
            TargetProcessServerId = targetProcessServerId;
            VmsToMigrate = vmsToMigrate;
            UpdateType = updateType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the container identifier.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the source process server.
        /// </summary>
        [JsonProperty(PropertyName = "sourceProcessServerId")]
        public string SourceProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the new process server.
        /// </summary>
        [JsonProperty(PropertyName = "targetProcessServerId")]
        public string TargetProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the VMS to migrate.
        /// </summary>
        [JsonProperty(PropertyName = "vmsToMigrate")]
        public IList<string> VmsToMigrate { get; set; }

        /// <summary>
        /// Gets or sets a value for failover type. It can be
        /// systemlevel/serverlevel.
        /// </summary>
        [JsonProperty(PropertyName = "updateType")]
        public string UpdateType { get; set; }

    }
}
