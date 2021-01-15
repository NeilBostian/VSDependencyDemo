using Newtonsoft.Json.Linq;
using System;

namespace NetStandardLib
{
    public static class Test
    {
        public static void TestJsonAndPrint()
        {
            string json = "{\"a\": \"bcdefghijk\"}";
            var obj = JObject.Parse(json);
            var str = obj["a"].ToObject<string>();
            Console.WriteLine(str);
        }
    }
}
