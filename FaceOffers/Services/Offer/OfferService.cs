using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class OfferService
    {
        public virtual async Task<FaceOffersOffer> Create(string token, FaceOffersOffer offer)
        {
            if (!offer.StartDate.HasValue)
                offer.StartDate = default(DateTime?);

            if(!offer.EndDate.HasValue)
                offer.EndDate = default(DateTime?);

            var response = await HttpHelper.Request(token, Urls.Offers, offer, HttpRequestType.POST);
            return Mapper<FaceOffersOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOffer> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Offers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOffer>> List(string token, Guid merchantId)
        {
            var url = string.Format("{0}/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOffer>> ListActive(string token, Guid merchantId)
        {
            var url = string.Format("{0}/Active/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOffer>> ListByApp(string token, Guid appId)
        {
            var url = string.Format("{0}/ByAppId/{1}", Urls.Offers, appId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOffer>> ListByTags(string token, string tags)
        {
            var url = string.Format("{0}/ByTags/{1}", Urls.Offers, tags);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferSummaryOptions>> ListSummary(string token, Guid merchantId)
        {
            var url = string.Format("{0}/Summary/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferSummaryOptions>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferSummaryOptions>> ListActiveSummary(string token, Guid merchantId)
        {
            var url = string.Format("{0}/ActiveSummary/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferSummaryOptions>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferSummaryOptions>> ListInactiveSummary(string token, Guid merchantId)
        {
            var url = string.Format("{0}/Inactive/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferSummaryOptions>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersOfferSummaryOptions>> ListExpiredSummary(string token, Guid merchantId)
        {
            var url = string.Format("{0}/Expired/{1}", Urls.Offers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersOfferSummaryOptions>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersOffer> Update(string token, FaceOffersOffer offer)
        {
            var response = await HttpHelper.Request(token, Urls.Offers, offer, HttpRequestType.PUT);
            return Mapper<FaceOffersOffer>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Offers, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
