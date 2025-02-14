// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BmcKeySetList represents a list of baseboard management controller key sets. </summary>
    internal partial class BmcKeySetList
    {
        /// <summary> Initializes a new instance of BmcKeySetList. </summary>
        internal BmcKeySetList()
        {
            Value = new ChangeTrackingList<BmcKeySetData>();
        }

        /// <summary> Initializes a new instance of BmcKeySetList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of baseboard management controller key sets. </param>
        internal BmcKeySetList(string nextLink, IReadOnlyList<BmcKeySetData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of baseboard management controller key sets. </summary>
        public IReadOnlyList<BmcKeySetData> Value { get; }
    }
}
