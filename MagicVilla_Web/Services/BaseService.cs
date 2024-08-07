﻿using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseServices
    {
        public APIResponse responseModel { get; set; }
        //calling api 
        public IHttpClientFactory httpClient { get; set; }
        public BaseService(IHttpClientFactory httpClient)
        {
            responseModel = new();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage massage = new HttpRequestMessage();
                massage.Headers.Add("Accept", "application/json");
                massage.RequestUri = new Uri(apiRequest.Url);
                if (apiRequest.Data != null)
                {
                    massage.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        massage.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        massage.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        massage.Method = HttpMethod.Delete;
                        break;
                    default:
                        massage.Method = HttpMethod.Get;
                        break;
                }
                HttpResponseMessage apiResponse = null;
                apiResponse = await client.SendAsync(massage);
                var apiConntent = await apiResponse.Content.ReadAsStringAsync();
                // deserilaizing the object
                var APIResponse = JsonConvert.DeserializeObject<T>(apiConntent);
                return APIResponse;
            }
            catch (Exception ex)
            {
                var dto = new APIResponse
                {
                    ErrorMassages = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var APIResponse = JsonConvert.DeserializeObject<T>(res);
                return APIResponse;
            }
        }
    }
}