using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class SharedOfferService
    {
        public virtual async Task<FaceOffersSharedOffer> Create(string token, FaceOffersSharedOffer sharedOffer)
        {
            var response = await HttpHelper.Request(token, Urls.SharedOffers, sharedOffer, HttpRequestType.POST);
            return Mapper<FaceOffersSharedOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersSharedOffer> Get(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.SharedOffers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersSharedOffer> Update(string token, FaceOffersSharedOffer sharedOffer)
        {
            var response = await HttpHelper.Request(token, Urls.SharedOffers, sharedOffer, HttpRequestType.PUT);
            return Mapper<FaceOffersSharedOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOffer>> List(string token, Guid offerId)
        {
            var url = string.Format("{0}/ByOfferId/{1}", Urls.SharedOffers, offerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOffer>> ListBySender(string token, Guid consumerId)
        {
            var url = string.Format("{0}/BySender/{1}", Urls.SharedOffers, consumerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOffer>> ListRedeemed(string token, Guid offerId)
        {
            var url = string.Format("{0}/Redeemed/{1}", Urls.SharedOffers, offerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOfferSummaryOptions>> ListSummary(string token, Guid consumerId)
        {
            var url = string.Format("{0}/ByConsumer/{1}", Urls.SharedOffers, consumerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOfferSummaryOptions>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.SharedOffers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
