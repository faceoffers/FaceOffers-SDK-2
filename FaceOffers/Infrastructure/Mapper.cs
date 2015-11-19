using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FaceOffersSDK
{
    public static class Mapper<T>
    {
        public static List<T> MapCollectionFromJson(string json)
        {
            var list = new List<T>();

            var jObject = JArray.Parse(json);

            foreach (var i in jObject)
                list.Add(Mapper<T>.MapFromJson(i.ToString()));

            return list;
        }

        public static T MapFromJson(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}