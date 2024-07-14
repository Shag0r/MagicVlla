using MagicVilla_Utility;
using MagicVilla_Web_new.Models;
using MagicVilla_Web_new.Models.Dto;
using MagicVilla_Web_new.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_Web_new.Services
{
    public class VillaService:BaseService, IVillaServices
    {
        readonly IHttpClientFactory _httpClientFactory;
        string villaUrl;
        public VillaService(IHttpClientFactory httpClientFactory,IConfiguration configuration):base(httpClientFactory) 
        {
            _httpClientFactory = httpClientFactory;
            // villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
            villaUrl = "http://localhost:5038/api/VillaAPI";



        }

        public Task<T> CreatedAsynce<T>(VillaCreateDTO dto)
        {
            return SendAsync<T>(
                new APIRequest()
                {
                    Apitype = SD.ApiType.POST,
                    Data = dto,
                   // Url = villaUrl+ "/api/VillaAPI"
                   Url = villaUrl
                }


                );
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(
                new APIRequest()
                {
                    Apitype = SD.ApiType.DELETE,
                    
                    Url = $"{villaUrl}/{id}"

                });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(
                new APIRequest()
                {
                    Apitype = SD.ApiType.GET,
                    //Url = villaUrl+ "/api/VillaAPI"
                    Url= villaUrl
                }
                
                );
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(
               new APIRequest()
               {
                   Apitype = SD.ApiType.GET,

                   // Url = villaUrl + "/api/VillaAPI/" + id
                   Url = $"{villaUrl}/{id}"
               }

               );

        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
        {
            return SendAsync<T>(
                new APIRequest()
                {
                    Apitype = SD.ApiType.PUT,
                    Data = dto,
                    //  Url = villaUrl + "/api/VillaAPI/" + dto.Id
                    Url = $"{villaUrl}/{dto.Id}"
                }

             );
        }


       




    }
}
