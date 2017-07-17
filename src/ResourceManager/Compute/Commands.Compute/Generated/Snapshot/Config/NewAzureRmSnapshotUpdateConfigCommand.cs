// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", "AzureRmSnapshotUpdateConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSSnapshotUpdate))]
    public class NewAzureRmSnapshotUpdateConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        public StorageAccountTypes? SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int? DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [Obsolete("This parameter is obsolete.  CreateOption cannot be changed during updating a snapshot." +
            "To set the CreateOption of a snapshot, use New-AzureRmSnapshotConfig command.",
            false)]
        public DiskCreateOption? CreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [Obsolete("This parameter is obsolete.  StorageAccountId cannot be changed during updating a snapshot." +
            "To set the StorageAccountId of a snapshot, use New-AzureRmSnapshotConfig command.",
            false)]
        public string StorageAccountId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [Obsolete("This parameter is obsolete.  ImageReference cannot be changed during updating a snapshot." +
            "To set the ImageReference of a snapshot, use New-AzureRmSnapshotConfig command.",
            false)]
        public ImageDiskReference ImageReference { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [Obsolete("This parameter is obsolete.  SourceUri cannot be changed during updating a snapshot." +
            "To set the SourceUri of a snapshot, use New-AzureRmSnapshotConfig command.",
            false)]
        public string SourceUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [Obsolete("This parameter is obsolete.  SourceResourceId cannot be changed during updating a snapshot." +
            "To set the SourceResourceId of a snapshot, use New-AzureRmSnapshotConfig command.",
            false)]
        public string SourceResourceId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? EncryptionSettingsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("SnapshotUpdate", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // EncryptionSettings
            Microsoft.Azure.Management.Compute.Models.EncryptionSettings vEncryptionSettings = null;

            // Sku
            Microsoft.Azure.Management.Compute.Models.DiskSku vSku = null;

            if (this.EncryptionSettingsEnabled != null)
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.Enabled = this.EncryptionSettingsEnabled;
            }

            if (this.DiskEncryptionKey != null)
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.DiskEncryptionKey = this.DiskEncryptionKey;
            }

            if (this.KeyEncryptionKey != null)
            {
                if (vEncryptionSettings == null)
                {
                    vEncryptionSettings = new Microsoft.Azure.Management.Compute.Models.EncryptionSettings();
                }
                vEncryptionSettings.KeyEncryptionKey = this.KeyEncryptionKey;
            }

            if (this.SkuName != null)
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.DiskSku();
                }
                vSku.Name = this.SkuName;
            }


            var vSnapshotUpdate = new PSSnapshotUpdate
            {
                OsType = this.OsType,
                DiskSizeGB = this.DiskSizeGB,
                Tags = (this.Tag == null) ? null : this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value),
                EncryptionSettings = vEncryptionSettings,
                Sku = vSku,
            };

            WriteObject(vSnapshotUpdate);
        }
    }
}

