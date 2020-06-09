// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentWhatIfProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (WhatIfSettings != null)
            {
                writer.WritePropertyName("whatIfSettings");
                writer.WriteObjectValue(WhatIfSettings);
            }
            writer.WritePropertyName("template");
            TemplateJson.WriteTo(writer);
            if (TemplateLink != null)
            {
                writer.WritePropertyName("templateLink");
                writer.WriteObjectValue(TemplateLink);
            }
            writer.WritePropertyName("parameters");
            ParametersJson.WriteTo(writer);
            if (ParametersLink != null)
            {
                writer.WritePropertyName("parametersLink");
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToSerialString());
            if (DebugSetting != null)
            {
                writer.WritePropertyName("debugSetting");
                writer.WriteObjectValue(DebugSetting);
            }
            if (OnErrorDeployment != null)
            {
                writer.WritePropertyName("onErrorDeployment");
                writer.WriteObjectValue(OnErrorDeployment);
            }
            writer.WriteEndObject();
        }
    }
}