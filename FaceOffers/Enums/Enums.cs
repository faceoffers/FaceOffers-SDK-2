using System.ComponentModel.DataAnnotations;

namespace FaceOffersSDK
{
    public enum OfferType : int
    {
        [Display(Name = "Dollar Based")]
        DollarOff = 0,
        [Display(Name = "Percentage Based")]
        PercentageOff = 1,
        [Display(Name = "Buy One Get One")]
        BOGO = 2
    }
}
