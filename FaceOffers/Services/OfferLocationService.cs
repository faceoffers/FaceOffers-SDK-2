using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class OfferLocationService
    {
        public virtual async Task<FaceOffersOfferLocation> Create(string token, FaceOffersOfferLocation offerLocation)
        {
            var response = await HttpHelper.Request(token, Urls.OfferLocations, offerLocation, HttpRequestType.POST);
            return Mapper<FaceOffersOfferLocation>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOfferLocation> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.OfferLocations, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferLocation>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferLocation>> ListByOffer(string token, Guid offerId)
        {
            var url = string.Format("{0}/ByOfferId/{1}", Urls.OfferLocations, offerId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferLocation>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferLocation>> ListByMerchantLocation(string token, Guid merchantLocationId)
        {
            var url = string.Format("{0}/ByMerchantLocationId/{1}", Urls.OfferLocations, merchantLocationId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferLocation>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.OfferLocations, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE);
        }
    }
}
