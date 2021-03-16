// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Query parameter to enumerate jobs.
    /// </summary>
    public partial class JobQueryParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>
        public JobQueryParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>
        /// <param name="startTime">Date time to get jobs from.</param>
        /// <param name="endTime">Date time to get jobs upto.</param>
        /// <param name="fabricId">The Id of the fabric to search jobs
        /// under.</param>
        /// <param name="affectedObjectTypes">The type of objects.</param>
        /// <param name="jobStatus">The states of the job to be filtered can be
        /// in.</param>
        /// <param name="jobOutputType">The output type of the jobs. Possible
        /// values include: 'Json', 'Xml', 'Excel'</param>
        /// <param name="jobName">The job Name.</param>
        /// <param name="timezoneOffset">The timezone offset for the location
        /// of the request (in minutes).</param>
        public JobQueryParameter(string startTime = default(string), string endTime = default(string), string fabricId = default(string), string affectedObjectTypes = default(string), string jobStatus = default(string), string jobOutputType = default(string), string jobName = default(string), double? timezoneOffset = default(double?))
        {
            StartTime = startTime;
            EndTime = endTime;
            FabricId = fabricId;
            AffectedObjectTypes = affectedObjectTypes;
            JobStatus = jobStatus;
            JobOutputType = jobOutputType;
            JobName = jobName;
            TimezoneOffset = timezoneOffset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date time to get jobs from.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets date time to get jobs upto.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the Id of the fabric to search jobs under.
        /// </summary>
        [JsonProperty(PropertyName = "fabricId")]
        public string FabricId { get; set; }

        /// <summary>
        /// Gets or sets the type of objects.
        /// </summary>
        [JsonProperty(PropertyName = "affectedObjectTypes")]
        public string AffectedObjectTypes { get; set; }

        /// <summary>
        /// Gets or sets the states of the job to be filtered can be in.
        /// </summary>
        [JsonProperty(PropertyName = "jobStatus")]
        public string JobStatus { get; set; }

        /// <summary>
        /// Gets or sets the output type of the jobs. Possible values include:
        /// 'Json', 'Xml', 'Excel'
        /// </summary>
        [JsonProperty(PropertyName = "jobOutputType")]
        public string JobOutputType { get; set; }

        /// <summary>
        /// Gets or sets the job Name.
        /// </summary>
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets the timezone offset for the location of the request
        /// (in minutes).
        /// </summary>
        [JsonProperty(PropertyName = "timezoneOffset")]
        public double? TimezoneOffset { get; set; }

    }
}
