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
    /// Response Object for supported os Api.
    /// </summary>
    public partial class ReplicationSupportedOperatingSystems : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationSupportedOperatingSystems class.
        /// </summary>
        public ReplicationSupportedOperatingSystems()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationSupportedOperatingSystems class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">Properties.</param>
        public ReplicationSupportedOperatingSystems(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, PropertyObject> properties = default(IDictionary<string, PropertyObject>))
            : base(id, name, type, location)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, PropertyObject> Properties { get; set; }

    }
}
