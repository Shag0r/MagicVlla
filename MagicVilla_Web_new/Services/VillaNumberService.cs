using MagicVilla_Utility;
using MagicVilla_Web_new.Models;
using MagicVilla_Web_new.Models.Dto;
using MagicVilla_Web_new.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;

namespace MagicVilla_Web_new.Services
{
    public class VillaNumberService:BaseService, IVillaNumberServices
    {
        readonly IHttpClientFactory _httpClientFactory;
        string villaUrl;
        public VillaNumberService(IHttpClientFactory httpClientFactory):base(httpClientFactory) 
        {
            _httpClientFactory = httpClientFactory;
            villaUrl = "http://localhost:5038/api/VillaNumberAPI";
           




        }


        //public Task<T> CreatedAsynce<T>(VillaNumberCreateDTO dto)
        //{
        //    return SendAsync<T>(
        //        new APIRequest()
        //        {
        //            Apitype = SD.ApiType.POST,
        //            Data = dto,
        //            Url = villaUrl
        //        }
        //    );
        //}
        public async Task<T> CreatedAsynce<T>(VillaNumberCreateDTO dto)
        {
            try
            {
                return await SendAsync<T>(new APIRequest
                {
                    Apitype = SD.ApiType.POST,
                    Data = dto,
                    Url = villaUrl
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreatedAsynce: {ex.Message}");
                throw; // Rethrow the exception to propagate it
            }
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

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(
                new APIRequest()
                {
                    Apitype = SD.ApiType.PUT,
                    Data = dto,
                    //  Url = villaUrl + "/api/VillaAPI/" + dto.Id
                    Url = $"{villaUrl}/{dto.villaNo}"
                }

             );
        }


       




    }
}
