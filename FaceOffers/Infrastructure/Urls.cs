namespace FaceOffersSDK
{
    internal static class Urls
    {
        public static string Apps
        {
            get { return BaseUrl + "/apps"; }
        }

        public static string Barcodes
        {
            get { return BaseUrl + "/Barcodes"; }
        }

        public static string Consumers
        {
            get { return BaseUrl + "/Consumers"; }
        }

        public static string Merchants
        {
            get { return BaseUrl + "/merchants"; }
        }

        public static string MerchantConsumers
        {
            get { return BaseUrl + "/MerchantConsumers"; }
        }

        public static string MerchantDevelopers
        {
            get { return BaseUrl + "/Developers"; }
        }

        public static string MerchantLocations
        {
            get { return BaseUrl + "/MerchantLocations"; }
        }

        public static string Offers
        {
            get { return BaseUrl + "/offers"; }
        }

        public static string OfferLocations
        {
            get { return BaseUrl + "/OfferLocations"; }
        }

        public static string OfferRewards
        {
            get { return BaseUrl + "/OfferRewards"; }
        }

        public static string Plans
        {
            get { return BaseUrl + "/plans"; }
        }

        public static string SharedOffers
        {
            get { return BaseUrl + "/SharedOffers"; }
        }

        public static string UniqueOffers
        {
            get { return BaseUrl + "/UniqueOffers"; }
        }

        public static string Users
        {
            get { return BaseUrl + "/users"; }
        }

        public static string Auth
        {
            get { return BaseUrl + "/apps/authenticate"; }
        }

        private static string BaseUrl
        {
            get { return "https://api.faceoffers.com/api"; }
        }
    }
}
