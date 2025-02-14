// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Swap resource properties. </summary>
    internal partial class CloudServiceSwapProperties
    {
        /// <summary> Initializes a new instance of CloudServiceSwapProperties. </summary>
        public CloudServiceSwapProperties()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceSwapProperties. </summary>
        /// <param name="slotType"> Specifies slot info on a cloud service. </param>
        internal CloudServiceSwapProperties(SwapSlotType? slotType)
        {
            SlotType = slotType;
        }

        /// <summary> Specifies slot info on a cloud service. </summary>
        public SwapSlotType? SlotType { get; set; }
    }
}
