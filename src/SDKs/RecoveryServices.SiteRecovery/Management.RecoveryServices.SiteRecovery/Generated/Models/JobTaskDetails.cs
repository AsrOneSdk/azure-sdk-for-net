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
    /// This class represents a task which is actually a workflow so that one
    /// can navigate to its individual drill down.
    /// </summary>
    public partial class JobTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobTaskDetails class.
        /// </summary>
        public JobTaskDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobTaskDetails class.
        /// </summary>
        /// <param name="jobTask">The job entity.</param>
        public JobTaskDetails(JobEntity jobTask = default(JobEntity))
        {
            JobTask = jobTask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job entity.
        /// </summary>
        [JsonProperty(PropertyName = "jobTask")]
        public JobEntity JobTask { get; set; }

    }
}
