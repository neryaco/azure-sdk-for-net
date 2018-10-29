// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Geographic and time constraints for Azure reachability report.
    /// </summary>
    public partial class AzureReachabilityReportParameters
    {
        /// <summary>
        /// Initializes a new instance of the AzureReachabilityReportParameters
        /// class.
        /// </summary>
        public AzureReachabilityReportParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureReachabilityReportParameters
        /// class.
        /// </summary>
        /// <param name="startTime">The start time for the Azure reachability
        /// report.</param>
        /// <param name="endTime">The end time for the Azure reachability
        /// report.</param>
        /// <param name="providers">List of Internet service providers.</param>
        /// <param name="azureLocations">Optional Azure regions to scope the
        /// query to.</param>
        public AzureReachabilityReportParameters(AzureReachabilityReportLocation providerLocation, System.DateTime startTime, System.DateTime endTime, IList<string> providers = default(IList<string>), IList<string> azureLocations = default(IList<string>))
        {
            ProviderLocation = providerLocation;
            Providers = providers;
            AzureLocations = azureLocations;
            StartTime = startTime;
            EndTime = endTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerLocation")]
        public AzureReachabilityReportLocation ProviderLocation { get; set; }

        /// <summary>
        /// Gets or sets list of Internet service providers.
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<string> Providers { get; set; }

        /// <summary>
        /// Gets or sets optional Azure regions to scope the query to.
        /// </summary>
        [JsonProperty(PropertyName = "azureLocations")]
        public IList<string> AzureLocations { get; set; }

        /// <summary>
        /// Gets or sets the start time for the Azure reachability report.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the Azure reachability report.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProviderLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProviderLocation");
            }
            if (ProviderLocation != null)
            {
                ProviderLocation.Validate();
            }
        }
    }
}