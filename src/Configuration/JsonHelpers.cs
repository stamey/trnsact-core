using System;
using System.Buffers;
using System.Buffers.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace trnsACT.Core.Configuration
{
    /// <summary>
    /// Class to allow attribute for handling json conversion in older versions of .NET
    /// For .NET 5+, use native attribute 
    /// [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    /// </summary>
    public class StringToIntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
                if (Utf8Parser.TryParse(span, out int number, out int bytesConsumed) && span.Length == bytesConsumed)
                {
                    return number;
                }

                if (int.TryParse(reader.GetString(), out number))
                {
                    return number;
                }
            }

            return reader.GetInt32();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
