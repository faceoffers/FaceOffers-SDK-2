using FaceOffersSDK.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FaceOffersSDK
{
    public partial class FaceOffersService
    {
        internal static string _faceOffersAPIKey = string.Empty;
        internal static string _userName = string.Empty;
        internal static Guid _merchantID = Guid.Empty;
        internal static Guid _appID = Guid.Empty;

        private AppService _App;
        private BarcodeService _Barcode;
        private ConsumerService _Consumer;
        private MerchantConsumerService _MerchantConsumer;
        private MerchantDeveloperService _MerchantDeveloper;
        private MerchantLocationService _MerchantLocation;
        private MerchantService _MerchantService;
        private OfferLocationService _OfferLocation;
        private OfferRewardService _OfferReward;
        private OfferService _Offer;
        private PlanService _Plan;
        private SharedOfferService _SharedOffer;
        private UniqueOfferService _UniqueOffer;
        private UserService _User;

        public string FaceOffersAPIKey
        {
            get
            {
                return _faceOffersAPIKey;
            }
        }

        public Guid MerchantID
        {
            get
            {
                return _merchantID;
            }
        }

        public Guid AppID
        {
            get
            {
                return _appID;
            }
        }

        private FaceOffersAppClaim _AuthToken = new FaceOffersAppClaim();
        public FaceOffersAppClaim AuthToken
        {
            get
            {
                return _AuthToken;
            }
            set
            {
                _AuthToken = value;
            }
        }

        #region Configuration
        public FaceOffersService(string apiKey, string username, FaceOffersAppClaim token = null)
        {
            Init(apiKey, username, token);
        }

        private void Init(string apiKey, string username, FaceOffersAppClaim token = null)
        {
            _faceOffersAPIKey = apiKey;
            _userName = username;

            if (token != null)
            {
                if (token.Expires <= DateTime.Now)
                {
                    GetAuthToken();
                }
                else
                {
                    AuthToken = token;
                }
            }
            else
            {
                GetAuthToken();
            }

            if (MerchantID == Guid.Empty)
                GetMerchantId();
        }

        private void GetAuthToken()
        {
            var data = new { ApiKey = _faceOffersAPIKey };

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var param = JsonConvert.SerializeObject(data);
            HttpContent contentPost = new StringContent(param, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(Urls.Auth, contentPost).Result;

            var result = response.Content;
            AuthToken = JsonConvert.DeserializeObject<FaceOffersAppClaim>(result.ReadAsStringAsync().Result);
            _appID = AuthToken.AppId;
        }

        private void GetMerchantId()
        {
            var userUrl = string.Format("{0}/ByUsername/{1}/", Urls.Users, _userName);
            var uResponse = HttpHelper.Request(_AuthToken.Token, userUrl, null, HttpRequestType.GET).Result;
            var user = Mapper<FaceOffersUser>.MapFromJson(uResponse.ReadAsStringAsync().Result);

            var merchantUrl = string.Format("{0}/ByUserId/{1}", Urls.Merchants, user.Id);
            var mResponse = HttpHelper.Request(_AuthToken.Token, merchantUrl, null, HttpRequestType.GET).Result;
            _merchantID = Mapper<FaceOffersMerchant>.MapFromJson(mResponse.ReadAsStringAsync().Result).Id;
        }
        #endregion

        #region Methods
        public AppService App
        {
            get 
            {
                if (_App == null)
                    _App = new AppService();
                return _App;
            }
        }

        public BarcodeService Barcode
        {
            get
            {
                if (_Barcode == null)
                    _Barcode = new BarcodeService();
                return _Barcode;
            }
        }

        public ConsumerService Consumer
        {
            get
            {
                if (_Consumer == null)
                    _Consumer = new ConsumerService();
                return _Consumer;
            }
        }

        public MerchantConsumerService MerchantConsumer
        {
            get
            {
                if (_MerchantConsumer == null)
                    _MerchantConsumer = new MerchantConsumerService();
                return _MerchantConsumer;
            }
        }

        public MerchantDeveloperService MerchantDeveloper
        {
            get 
            {
                if (_MerchantDeveloper == null)
                    _MerchantDeveloper = new MerchantDeveloperService();
                return _MerchantDeveloper;
            }
        }

        public MerchantLocationService MerchantLocation
        {
            get
            {
                if (_MerchantLocation == null)
                    _MerchantLocation = new MerchantLocationService();
                return _MerchantLocation;
            }
        }

        public MerchantService MerchantService
        {
            get
            {
                if (_MerchantService == null)
                    _MerchantService = new MerchantService();
                return _MerchantService;
            }
        }

        public OfferLocationService OfferLocation
        {
            get
            {
                if (_OfferLocation == null)
                    _OfferLocation = new OfferLocationService();
                return _OfferLocation;
            }
        }

        public OfferRewardService OfferReward
        {
            get
            {
                if (_OfferReward == null)
                    _OfferReward = new OfferRewardService();
                return _OfferReward;
            }
        }

        public OfferService Offer
        {
            get
            {
                if (_Offer == null)
                    _Offer = new OfferService();
                return _Offer;
            }
        }

        public PlanService Plan
        {
            get
            {
                if (_Plan == null)
                    _Plan = new PlanService();
                return _Plan;
            }
        }

        public SharedOfferService SharedOffer
        {
            get
            {
                if (_SharedOffer == null)
                    _SharedOffer = new SharedOfferService();
                return _SharedOffer;
            }
        }

        public UniqueOfferService UniqueOffer
        {
            get
            {
                if (_UniqueOffer == null)
                    _UniqueOffer = new UniqueOfferService();
                return _UniqueOffer;
            }
        }

        public UserService User
        {
            get
            {
                if (_User == null)
                    _User = new UserService();
                return _User;
            }
        }
        #endregion
    }
}
