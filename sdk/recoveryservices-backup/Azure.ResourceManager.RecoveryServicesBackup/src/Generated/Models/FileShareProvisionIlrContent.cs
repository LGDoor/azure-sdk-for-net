// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Update snapshot Uri with the correct friendly Name of the source Azure file share. </summary>
    public partial class FileShareProvisionIlrContent : IlrContent
    {
        /// <summary> Initializes a new instance of <see cref="FileShareProvisionIlrContent"/>. </summary>
        public FileShareProvisionIlrContent()
        {
            ObjectType = "AzureFileShareProvisionILRRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FileShareProvisionIlrContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointId"> Recovery point ID. </param>
        /// <param name="sourceResourceId"> Source Storage account ARM Id. </param>
        internal FileShareProvisionIlrContent(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, string recoveryPointId, ResourceIdentifier sourceResourceId) : base(objectType, serializedAdditionalRawData)
        {
            RecoveryPointId = recoveryPointId;
            SourceResourceId = sourceResourceId;
            ObjectType = objectType ?? "AzureFileShareProvisionILRRequest";
        }

        /// <summary> Recovery point ID. </summary>
        public string RecoveryPointId { get; set; }
        /// <summary> Source Storage account ARM Id. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
    }
}
