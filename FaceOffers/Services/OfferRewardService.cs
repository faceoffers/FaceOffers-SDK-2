using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class OfferRewardService
    {
        public virtual async Task<FaceOffersOfferReward> Create(string token, FaceOffersOfferReward offerReward)
        {
            var response = await HttpHelper.Request(token, Urls.OfferRewards, offerReward, HttpRequestType.POST);
            return Mapper<FaceOffersOfferReward>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOfferReward> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.OfferRewards, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferReward>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOfferReward> GetByOffer(string token, Guid offerId)
        {
            var url = string.Format("{0}/ByOfferId/{1}", Urls.OfferRewards, offerId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferReward>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOfferReward> Update(string token, FaceOffersOfferReward offerReward)
        {
            var response = await HttpHelper.Request(token, Urls.OfferRewards, offerReward, HttpRequestType.PUT);
            return Mapper<FaceOffersOfferReward>.MapFromJson(await response.ReadAsStringAsync());
        }
    }
}
