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
    /// Health Error.
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
        /// <param name="innerHealthErrors">The inner health errors.
        /// HealthError having a list of HealthError as child errors is
        /// problematic. InnerHealthError is used because this will prevent an
        /// infinite loop of structures when Hydra tries to auto-generate the
        /// contract. We are exposing the related health errors as inner health
        /// errors and all API consumers can utilize this in the same fashion
        /// as Exception -&amp;gt; InnerException.</param>
        /// <param name="errorSource">Source of error.</param>
        /// <param name="errorType">Type of error.</param>
        /// <param name="errorLevel">Level of error.</param>
        /// <param name="errorCategory">Category of error.</param>
        /// <param name="errorCode">Error code.</param>
        /// <param name="summaryMessage">Summary message of the entity.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="possibleCauses">Possible causes of error.</param>
        /// <param name="recommendedAction">Recommended action to resolve
        /// error.</param>
        /// <param name="creationTimeUtc">Error creation time (UTC).</param>
        /// <param name="recoveryProviderErrorMessage">DRA error
        /// message.</param>
        /// <param name="entityId">ID of the entity.</param>
        public HealthError(IList<InnerHealthError> innerHealthErrors = default(IList<InnerHealthError>), string errorSource = default(string), string errorType = default(string), string errorLevel = default(string), string errorCategory = default(string), string errorCode = default(string), string summaryMessage = default(string), string errorMessage = default(string), string possibleCauses = default(string), string recommendedAction = default(string), System.DateTime? creationTimeUtc = default(System.DateTime?), string recoveryProviderErrorMessage = default(string), string entityId = default(string))
        {
            InnerHealthErrors = innerHealthErrors;
            ErrorSource = errorSource;
            ErrorType = errorType;
            ErrorLevel = errorLevel;
            ErrorCategory = errorCategory;
            ErrorCode = errorCode;
            SummaryMessage = summaryMessage;
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
        /// Gets or sets the inner health errors. HealthError having a list of
        /// HealthError as child errors is problematic. InnerHealthError is
        /// used because this will prevent an infinite loop of structures when
        /// Hydra tries to auto-generate the contract. We are exposing the
        /// related health errors as inner health errors and all API consumers
        /// can utilize this in the same fashion as Exception -&amp;amp;gt;
        /// InnerException.
        /// </summary>
        [JsonProperty(PropertyName = "innerHealthErrors")]
        public IList<InnerHealthError> InnerHealthErrors { get; set; }

        /// <summary>
        /// Gets or sets source of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorSource")]
        public string ErrorSource { get; set; }

        /// <summary>
        /// Gets or sets type of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorType")]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or sets level of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorLevel")]
        public string ErrorLevel { get; set; }

        /// <summary>
        /// Gets or sets category of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorCategory")]
        public string ErrorCategory { get; set; }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets summary message of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "summaryMessage")]
        public string SummaryMessage { get; set; }

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
        /// Gets or sets error creation time (UTC).
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
