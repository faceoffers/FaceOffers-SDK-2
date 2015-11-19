using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class AppService
    {
        public virtual async Task<FaceOffersApp> Create(string token, FaceOffersApp app)
        {
            var response = await HttpHelper.Request(token, Urls.Apps, app, HttpRequestType.POST);
            return Mapper<FaceOffersApp>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersApp> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Apps, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersApp>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersApp> Update(string token, FaceOffersApp app)
        {
            var response = await HttpHelper.Request(token, Urls.Apps, app, HttpRequestType.PUT);
            return Mapper<FaceOffersApp>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersApp>> List(string token, Guid merchantId)
        {
            var url = string.Format("{0}/{1}", Urls.Apps, merchantId);

            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersApp>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Apps, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
