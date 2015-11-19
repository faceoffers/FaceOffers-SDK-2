using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FaceOffersSDK
{
    internal static class HttpHelper
    {
        public static async Task<HttpContent> Request(string token, string url, object data, HttpRequestType type)
        {
            using (var client = new HttpClient())
            { 
                client.DefaultRequestHeaders.Add("X-API-TOKENAUTH", token);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = null;

                    switch (type)
                    {
                        case HttpRequestType.GET:
                            {
                                response = await client.GetAsync(url);
                                break;
                            }

                        case HttpRequestType.POST:
                            {
                                var param = JsonConvert.SerializeObject(data);
                                HttpContent contentPost = new StringContent(param, Encoding.UTF8, "application/json");
                                response = await client.PostAsync(url, contentPost);
                                break;
                            }

                        case HttpRequestType.PUT:
                            {
                                var param = JsonConvert.SerializeObject(data);
                                HttpContent contentPost = new StringContent(param, Encoding.UTF8, "application/json");
                                response = await client.PutAsync(url, contentPost);
                                break;
                            }

                        case HttpRequestType.DELETE:
                            {
                                response = await client.DeleteAsync(url);
                                break;
                            }


                        default:
                            throw new Exception("Unsupported Request Type");
                    } 
                    response.EnsureSuccessStatusCode();
                    return response.Content;
                }
                catch (HttpRequestException requestException)
                {
                    //if (requestException != null)
                    //{ 
                    //    //var statusCode = requestException.

                    //    var faceOffersError = new FaceOffersError();

                    //    throw new FaceOffersException(statusCode, faceOffersError, faceOffersError.Message);
                    //}

                    throw;
                }
            }
        }

        //public static string Request(string url, HttpRequestType type, FaceOffersRequestOptions requestOptions)
        //{
        //    var request = GetWebRequest(url, type, requestOptions);
        //    return ExecuteWebRequest(request);
        //}

        //internal static WebRequest GetWebRequest(string url, HttpRequestType method, FaceOffersRequestOptions requestOptions)
        //{
        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    switch (method)
        //    {
        //        case HttpRequestType.GET:
        //            request.Method = "GET";
        //            break;
        //        case HttpRequestType.POST:
        //            request.Method = "POST";
        //            break;
        //        case HttpRequestType.PUT:
        //            request.Method = "PUT";
        //            break;
        //        case HttpRequestType.DELETE:
        //            request.Method = "DELETE";
        //            break;
        //        default:
        //            throw new Exception("Unsupported Request Type");
        //    }

        //    request.Headers.Add("X-API-TOKENAUTH", requestOptions.Token);
        //    request.ContentType = "application/json;charset=\"utf-8\"";

        //    return request;
        //}

        //private static string ExecuteWebRequest(WebRequest webRequest)
        //{
        //    try
        //    {
        //        using (var response = webRequest.GetResponse())
        //        {
        //            return ReadStream(response.GetResponseStream());
        //        }
        //    }
        //    catch (WebException webException)
        //    {
        //        if (webException.Response != null)
        //        {
        //            var statusCode = ((HttpWebResponse)webException.Response).StatusCode;

        //            var faceOffersError = new FaceOffersError();

        //            throw new FaceOffersException(statusCode, faceOffersError, faceOffersError.Message);
        //        }

        //        throw;
        //    }
        //}

        //private static string ReadStream(Stream stream)
        //{
        //    using (var reader = new StreamReader(stream, Encoding.UTF8))
        //    {
        //        return reader.ReadToEnd();
        //    }
        //}
    }

    public enum HttpRequestType
    {
        GET,
        POST,
        PUT,
        DELETE,
        HEAD
    }
}
