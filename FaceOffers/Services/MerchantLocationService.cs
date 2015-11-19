using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class MerchantLocationService
    {
        public virtual async Task<FaceOffersMerchantLocation> Create(string token, FaceOffersMerchantLocation merchantLocation)
        {
            var response = await HttpHelper.Request(token, Urls.MerchantLocations, merchantLocation, HttpRequestType.POST);
            return Mapper<FaceOffersMerchantLocation>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantLocation> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.MerchantLocations, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantLocation>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantLocation> Update(string token, FaceOffersMerchantLocation merchantLocation)
        {
            var response = await HttpHelper.Request(token, Urls.MerchantLocations, merchantLocation, HttpRequestType.PUT);
            return Mapper<FaceOffersMerchantLocation>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersMerchantLocation>> List(string token, Guid merchantId)
        {
            var url = string.Format("{0}/{1}", Urls.MerchantLocations, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantLocation>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.MerchantLocations, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
