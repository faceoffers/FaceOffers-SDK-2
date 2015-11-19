using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class UniqueOfferService
    {
        public virtual async Task<FaceOffersUniqueOffer> Create(string token, FaceOffersUniqueOffer uniqueOffer)
        {
            var response = await HttpHelper.Request(token, Urls.UniqueOffers, uniqueOffer, HttpRequestType.POST);
            return Mapper<FaceOffersUniqueOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUniqueOffer> Get(string token, Guid offerId)
        {
            var url = string.Format("{0}/{1}", Urls.UniqueOffers, offerId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUniqueOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUniqueOffer> GetByConsumer(string token, Guid consumerId)
        {
            var url = string.Format("{0}/ByConsumer/{1}", Urls.UniqueOffers, consumerId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUniqueOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUniqueOffer> GetByOfferAndConsumer(string token, Guid offerId, Guid consumerId)
        {
            var url = string.Format("{0}/ByOfferConsumerIds/{1}/{2}", Urls.UniqueOffers, offerId, consumerId);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUniqueOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersUniqueOffer> Update(string token, FaceOffersUniqueOffer uniqueOffer)
        {
            var response = await HttpHelper.Request(token, Urls.UniqueOffers, uniqueOffer, HttpRequestType.PUT);
            return Mapper<FaceOffersUniqueOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersUniqueOffer>> ListByOffer(string token, Guid offerId)
        {
            var url = string.Format("{0}/ByOfferId/{1}", Urls.UniqueOffers, offerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUniqueOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersUniqueOffer>> ListByConsumer(string token, Guid consumerId)
        {
            var url = string.Format("{0}/ByConsumerId/{1}", Urls.UniqueOffers, consumerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersUniqueOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.UniqueOffers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
