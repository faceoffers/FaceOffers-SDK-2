using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaceOffersSDK.Services
{
    public class BarcodeService
    {
        public virtual async Task<FaceOffersBarcode> Create(string token, FaceOffersBarcode barcode)
        {
            var response = await HttpHelper.Request(token, Urls.Barcodes, barcode, HttpRequestType.POST);
            return Mapper<FaceOffersBarcode>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersBarcode> Get(string token, Guid id)
        {
            var url = string.Format("{0}/ById/{1}", Urls.Barcodes, id);
            var response = await HttpHelper.Request(token, url, null, HttpRequestType.GET);
            return Mapper<FaceOffersBarcode>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual async Task<FaceOffersBarcode> Update(string token, FaceOffersBarcode barcode)
        {
            var response = await HttpHelper.Request(token, Urls.Barcodes, barcode, HttpRequestType.PUT);
            return Mapper<FaceOffersBarcode>.MapFromJson(await response.ReadAsStringAsync());
        }

        public virtual void Delete(string token, Guid id)
        {
            var url = string.Format("{0}/{1}", Urls.Barcodes, id);
            var response = HttpHelper.Request(token, url, null, HttpRequestType.DELETE).Result;
        }
    }
}
