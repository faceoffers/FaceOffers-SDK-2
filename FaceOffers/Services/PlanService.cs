using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class PlanService
    {
        public virtual async Task<FaceOffersPlan> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Plans, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersPlan>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersPlan>> List(string token)
        {
            HttpContent response = await HttpHelper.Request(token, Urls.Plans, null, HttpRequestType.GET);
            return Mapper<FaceOffersPlan>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersPlan>> UpgradablePlanList(string token, int level)
        {
            var url = string.Format("{0}/UpgradablePlans/{1}", Urls.Plans, level);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersPlan>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersPlan>> DowngradablePlanList(string token, int level)
        {
            var url = string.Format("{0}/DowngradablePlans/{1}", Urls.Plans, level);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersPlan>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }
    }
}
