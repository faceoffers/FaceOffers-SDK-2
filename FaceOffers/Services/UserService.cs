using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class UserService
    {
        public virtual async Task<FaceOffersUser> Create(string token, FaceOffersUser user)
        {
            var response = await HttpHelper.Request(token, Urls.Users, user, HttpRequestType.POST);
            return Mapper<FaceOffersUser>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUser> Get(string token, string id)
        {
            var url = string.Format("{0}/ById/{1}/", Urls.Users, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUser>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUser> GetByUserName(string token, string username)
        {
            var url = string.Format("{0}/ByUsername/{1}/", Urls.Users, username);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUser>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUser> Update(string token, FaceOffersUser user)
        {
            var response = await HttpHelper.Request(token, Urls.Users, user, HttpRequestType.PUT);
            return Mapper<FaceOffersUser>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Users, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE);
        }
    }
}
