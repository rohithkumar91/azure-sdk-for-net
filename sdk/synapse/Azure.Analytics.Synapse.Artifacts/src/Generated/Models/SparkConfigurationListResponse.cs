// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of sparkconfiguration resources. </summary>
    internal partial class SparkConfigurationListResponse
    {
        /// <summary> Initializes a new instance of SparkConfigurationListResponse. </summary>
        /// <param name="value"> List of sparkconfigurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SparkConfigurationListResponse(IEnumerable<SparkConfigurationResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SparkConfigurationListResponse. </summary>
        /// <param name="value"> List of sparkconfigurations. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal SparkConfigurationListResponse(IReadOnlyList<SparkConfigurationResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of sparkconfigurations. </summary>
        public IReadOnlyList<SparkConfigurationResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
