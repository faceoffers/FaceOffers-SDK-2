using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class MerchantConsumerService
    {
        public virtual async Task<FaceOffersMerchantConsumer> Create(string token, FaceOffersMerchantConsumer merchantConsumer)
        {
            var response = await HttpHelper.Request(token, Urls.MerchantConsumers, merchantConsumer, HttpRequestType.POST);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantConsumer> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.MerchantConsumers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantConsumer> GetByConsumer(string token, Guid consumerId)
        {
            var url = string.Format("{0}/ByConsumer/{1}", Urls.MerchantConsumers, consumerId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }
        
        public virtual async Task<FaceOffersMerchantConsumer> GetByPhone(string token, string phoneNumber)
        {
            var url = string.Format("{0}/ByConsumerPhone/{1}", Urls.MerchantConsumers, phoneNumber);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantConsumer> GetByEmail(string token, string emailAddress)
        {
            var url = string.Format("{0}/ByConsumerEmail/{1}", Urls.MerchantConsumers, emailAddress);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantConsumerSummaryOptions> GetProfile(string token, Guid id)
        {
            var url = string.Format("{0}/ByConsumerId/{1}", Urls.MerchantConsumers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantConsumerSummaryOptions>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantConsumer> Update(string token, FaceOffersMerchantConsumer merchantConsumer)
        {
            var response = await HttpHelper.Request(token, Urls.MerchantConsumers, merchantConsumer, HttpRequestType.PUT);
            return Mapper<FaceOffersMerchantConsumer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.MerchantConsumers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
