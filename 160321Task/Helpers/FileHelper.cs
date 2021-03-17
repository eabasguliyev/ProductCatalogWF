using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text;
using _160321Task.Entities;
using Newtonsoft.Json;

namespace _160321Task.Helpers
{
    public static class FileHelper
    {
        private static JsonSerializer _serializer;
        public static string FileName { get; set; }
        static FileHelper()
        {
            _serializer = new JsonSerializer();
        }

        public static void WriteToJson(List<Product> products)
        {
            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        _serializer.Serialize(jw, products);
                    }
                }
            }
        }

        public static List<Product> ReadFromJson()
        {
            List<Product> products = null;

            using (var fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        products = _serializer.Deserialize<List<Product>>(jr);
                    }
                }
            }

            return products;
        }
    }
}