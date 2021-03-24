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
    /// Recovery plan update properties.
    /// </summary>
    public partial class UpdateRecoveryPlanInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the UpdateRecoveryPlanInputProperties
        /// class.
        /// </summary>
        public UpdateRecoveryPlanInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateRecoveryPlanInputProperties
        /// class.
        /// </summary>
        /// <param name="groups">The recovery plan groups.</param>
        public UpdateRecoveryPlanInputProperties(IList<RecoveryPlanGroup> groups = default(IList<RecoveryPlanGroup>))
        {
            Groups = groups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery plan groups.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<RecoveryPlanGroup> Groups { get; set; }

    }
}
