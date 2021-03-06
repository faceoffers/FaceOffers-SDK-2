﻿using System;
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

        public virtual async Task<FaceOffersSharedOffer> GetById(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.SharedOffers, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
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
        
         public virtual async Task<IEnumerable<FaceOffersSharedOffer>> ListByMerchant(string token, Guid merchantId)
        {
            var url = string.Format("{0}/ByMerchant/{1}", Urls.SharedOffers, merchantId);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOffer>> ListBySearch(string token, Guid merchantId, string barcode)
        {
            var url = string.Format("{0}/ByMerchant/Search/{1}/{2}", Urls.SharedOffers, merchantId, barcode);
            HttpContent response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersSharedOffer>.MapCollectionFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<IEnumerable<FaceOffersSharedOffer>> ListBySenderAndOffer(string token, Guid consumerId, Guid offerId)
        {
            var url = string.Format("{0}/BySenderAndOffer/{1}/{2}", Urls.SharedOffers, consumerId, offerId);
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
