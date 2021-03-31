// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookResourceConverter))]
    public partial class NotebookResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static NotebookResource DeserializeNotebookResource(JsonElement element)
        {
            Optional<string> id = default;
            string name = default;
            Optional<string> type = default;
            Optional<string> etag = default;
            Notebook properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = Notebook.DeserializeNotebook(property.Value);
                    continue;
                }
            }
            return new NotebookResource(id.Value, name, type.Value, etag.Value, properties);
        }

        internal partial class NotebookResourceConverter : JsonConverter<NotebookResource>
        {
            public override void Write(Utf8JsonWriter writer, NotebookResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookResource(document.RootElement);
            }
        }
    }
}
