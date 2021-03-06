// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// The health error class.
    /// </summary>
    public partial class HealthError
    {
        /// <summary>
        /// Initializes a new instance of the HealthError class.
        /// </summary>
        public HealthError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HealthError class.
        /// </summary>
        /// <param name="errorLevel">Level of error.</param>
        /// <param name="errorCode">Error code.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="possibleCauses">Possible causes of error.</param>
        /// <param name="recommendedAction">Recommended action to resolve
        /// error.</param>
        /// <param name="creationTimeUtc">Error creation time (UTC)</param>
        /// <param name="recoveryProviderErrorMessage">DRA error
        /// message.</param>
        /// <param name="entityId">ID of the entity.</param>
        public HealthError(string errorLevel = default(string), string errorCode = default(string), string errorMessage = default(string), string possibleCauses = default(string), string recommendedAction = default(string), System.DateTime? creationTimeUtc = default(System.DateTime?), string recoveryProviderErrorMessage = default(string), string entityId = default(string))
        {
            ErrorLevel = errorLevel;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            CreationTimeUtc = creationTimeUtc;
            RecoveryProviderErrorMessage = recoveryProviderErrorMessage;
            EntityId = entityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets level of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorLevel")]
        public string ErrorLevel { get; set; }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets possible causes of error.
        /// </summary>
        [JsonProperty(PropertyName = "possibleCauses")]
        public string PossibleCauses { get; set; }

        /// <summary>
        /// Gets or sets recommended action to resolve error.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Gets or sets error creation time (UTC)
        /// </summary>
        [JsonProperty(PropertyName = "creationTimeUtc")]
        public System.DateTime? CreationTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets DRA error message.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProviderErrorMessage")]
        public string RecoveryProviderErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets ID of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

    }
}
