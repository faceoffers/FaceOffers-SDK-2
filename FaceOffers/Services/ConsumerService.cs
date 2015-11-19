using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class ConsumerService
    {
        public virtual async Task<FaceOffersConsumer> Create(string token, FaceOffersConsumer consumer)
        {
            var response = await HttpHelper.Request(token, Urls.Consumers, consumer, HttpRequestType.POST);
            return Mapper<FaceOffersConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersConsumer> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Consumers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersConsumer> Update(string token, FaceOffersConsumer consumer)
        {
            var response = await HttpHelper.Request(token, Urls.Consumers, consumer, HttpRequestType.PUT);
            return Mapper<FaceOffersConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Consumers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
