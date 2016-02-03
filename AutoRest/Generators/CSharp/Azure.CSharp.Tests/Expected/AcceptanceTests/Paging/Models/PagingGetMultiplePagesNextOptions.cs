// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsPaging.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Additional parameters for the getMultiplePagesNext operation.
    /// </summary>
    public partial class PagingGetMultiplePagesNextOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PagingGetMultiplePagesNextOptions class.
        /// </summary>
        public PagingGetMultiplePagesNextOptions() { }

        /// <summary>
        /// Initializes a new instance of the
        /// PagingGetMultiplePagesNextOptions class.
        /// </summary>
        public PagingGetMultiplePagesNextOptions(int? maxresults = default(int?), int? timeout = default(int?))
        {
            Maxresults = maxresults;
            Timeout = timeout;
        }

        /// <summary>
        /// Sets the maximum number of items to return in the response.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? Maxresults { get; set; }

        /// <summary>
        /// Sets the maximum time that the server can spend processing the
        /// request, in seconds. The default is 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? Timeout { get; set; }

    }
}