using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class MerchantDeveloperService
    {
        public virtual async Task<FaceOffersMerchantDeveloper> Create(string token, FaceOffersMerchantDeveloper merchantDeveloper)
        {
            var response = await HttpHelper.Request(token, Urls.MerchantDevelopers, merchantDeveloper, HttpRequestType.POST);
            return Mapper<FaceOffersMerchantDeveloper>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantDeveloper> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.MerchantDevelopers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantDeveloper>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchantDeveloper> GetByUser(string token, Guid userId)
        {
            var url = string.Format("{0}/ByUserId/{1}", Urls.MerchantDevelopers, userId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantDeveloper>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersMerchantDeveloper>> List(string token, Guid merchantId)
        {
            var url = string.Format("{0}/{1}", Urls.MerchantDevelopers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantDeveloper>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersMerchantDeveloper>> ListByUser(string token, string userId)
        {
            var url = string.Format("{0}/AllByUserId/{1}", Urls.MerchantDevelopers, userId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchantDeveloper>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.MerchantDevelopers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
