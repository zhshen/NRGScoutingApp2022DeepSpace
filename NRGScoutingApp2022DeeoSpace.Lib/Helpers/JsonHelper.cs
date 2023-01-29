using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NRGScoutingApp2022DeeoSpace.Lib.Helpers
{
    public static class JsonHelper
    {
        private static readonly JsonSerializerOptions _DefaultOption = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public static TValue? LoadEmbededData<TValue>(string jsonName)
        {
            string path = $"NRGScoutingApp2022DeepSpace.Resources.Data.{jsonName}.json";

            using (Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
            {
                if (stream == null)
                    throw new InvalidOperationException($"Can not get resource fomr '{path}'");

                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonHelper.Deserialize<TValue>(reader.ReadToEnd());
                }
            }
        }

        public static string Serialize<TValue>(TValue value)
        {
            return JsonSerializer.Serialize(value, _DefaultOption);
        }

        public static TValue? Deserialize<TValue>(string json)
        {
            return JsonSerializer.Deserialize<TValue>(json, _DefaultOption);
        }
    }
}
