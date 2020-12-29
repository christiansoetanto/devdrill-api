using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevDrillAPI.Helper.Extensions
{
    public static class JsonExtension
    {
        public static T GetObject<T>(this JsonElement element)
        {
            var json = element.GetRawText();
            return JsonSerializer.Deserialize<T>(json,new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        public static T GetObject<T>(this JsonDocument document)
        {
            var json = document.RootElement.GetRawText();
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
