using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NWFrontEndApp.Utilities
{
    public class MSDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var rawValue = reader.GetString();

            if (rawValue != null && rawValue.StartsWith("/Date(") && rawValue.EndsWith(")/"))
            {
                var timestamp = rawValue.Substring(6, rawValue.IndexOf(')') - 6); // Extrae "843022800000-0500"
                var milliseconds = long.Parse(timestamp.Split('-')[0]);         // Obtiene solo los milisegundos
                return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).UtcDateTime;
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                var milliseconds = new DateTimeOffset(value.Value).ToUnixTimeMilliseconds();
                writer.WriteStringValue($"/Date({milliseconds})/");
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
