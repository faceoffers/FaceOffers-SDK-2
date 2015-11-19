using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FaceOffersSDK;

namespace FaceOffers.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string faceoffersApiKey = "<YOUR API KEY HERE>";
            string faceoffersUsername = "<YOUR FACEOFFERS USERNAME HERE>";

            // initialize FaceOffers
            FaceOffersService service = new FaceOffersService(faceoffersApiKey, faceoffersUsername);

            #region Offer
            // list all merchant's offers
            IEnumerable<FaceOffersOffer> offers = service.Offer.List(service.AuthToken.Token, service.MerchantID).Result;
            
            // create an offer
            var newOffer = new FaceOffersOffer();
            newOffer.MerchantId = service.MerchantID;
            newOffer.AppId = service.AppID;
            newOffer.Name = "Pre-Holiday Sale!";
            newOffer.TermsConditions = "30% off";
            newOffer.Tags = "Holiday, Sale, Christmas";
            newOffer.Type = OfferType.PercentageOff;
            newOffer.Reward = "30";
            newOffer.Limited = true;
            newOffer.RedemptionLimit = 10;
            newOffer.StartDate = new DateTime(2015, 11, 14);
            newOffer.EndDate = new DateTime(2015, 11, 16);
            newOffer.OfferImage = string.Empty;
            FaceOffersOffer response = service.Offer.Create(service.AuthToken.Token, newOffer).Result;

            // retrieve an offer
            //FaceOffersOffer offer = service.Offer.Get(service.AuthToken.Token, *offerId*).result; // uncomment this and substitute with OfferId

            // update an offer
            //FaceOffersOffer updateResponse = service.Offer.Update(service.AuthToken.Token, *myOffer*).result; // uncomment this and substitute with offer object

            // delete an offer
            //service.Offer.Delete(service.AuthToken.Token, *offerId*).result; // uncomment this and substitute with OfferId
            #endregion

            Console.ReadKey();
        }
    }
}
