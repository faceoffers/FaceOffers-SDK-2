using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class MerchantService
    {
        public virtual async Task<FaceOffersMerchant> Create(string token, FaceOffersMerchant merchant)
        {
            var response = await HttpHelper.Request(token, Urls.Merchants, merchant, HttpRequestType.POST);
            return Mapper<FaceOffersMerchant>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchant> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Merchants, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchant>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchant> GetByUser(string token, Guid userId)
        {
            var url = string.Format("{0}/ByUserId/{1}", Urls.Merchants, userId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersMerchant>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersMerchant> Update(string token, FaceOffersMerchant merchant)
        {
            var response = await HttpHelper.Request(token, Urls.Merchants, merchant, HttpRequestType.PUT);
            return Mapper<FaceOffersMerchant>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Merchants, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
