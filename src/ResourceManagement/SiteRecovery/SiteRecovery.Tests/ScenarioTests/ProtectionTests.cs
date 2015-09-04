//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.SiteRecovery.Models;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Test;
using System.Net;
using Xunit;


namespace SiteRecovery.Tests
{
    public class ProtectionTests : SiteRecoveryTestsBase
    {
        [Fact]
        public void EnableDR()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                string fabricId = "6adf9420-b02f-4377-8ab7-ff384e6d792f";
                string containerId = "4f94127d-2eb3-449d-a708-250752e93cb4";
                //string peId = "4d63fad7-eb47-4f47-8f2b-c789ec853a58";
                string peId = "052ca37a-cdca-441f-82ba-55d22de2409e";

                var container = client.ProtectionContainer.Get(fabricId, containerId, RequestHeaders);

                EnableProtectionInputProperties enableDRInputProperties = new EnableProtectionInputProperties()
                {
                    PolicyId = container.ProtectionContainer.Properties.AssociationDetails[0].PairedPolicyDetails[0].PolicyArmId,
                    ProviderSettings = new EnableProtectionProviderSpecificInput(),
                    ProtectableItemId = peId,
                    Name = peId
                };

                EnableProtectionInput enableDRInput = new EnableProtectionInput()
                {
                    Properties = enableDRInputProperties
                };

                var response = client.ReplicationProtectedItem.EnableProtection(fabricId, containerId, enableDRInput, RequestHeaders);
            }
        }

        [Fact]
        public void DisableDR()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetSiteRecoveryClient(CustomHttpHandler);

                string fabricId = "6adf9420-b02f-4377-8ab7-ff384e6d792f";
                string containerId = "4f94127d-2eb3-449d-a708-250752e93cb4";
                string peId = "052ca37a-cdca-441f-82ba-55d22de2409e";

                DisableProtectionInputProperties disableDRInputProperties = new DisableProtectionInputProperties()
                {
                    ReplicationProtectedItemName = peId,
                    ProviderSettings = null
                };

                DisableProtectionInput disableDrInput = new DisableProtectionInput()
                {
                    Properties = disableDRInputProperties
                };

                var response = client.ReplicationProtectedItem.DisableProtection(fabricId, containerId, disableDrInput, RequestHeaders);
            }
        }
    }
}
