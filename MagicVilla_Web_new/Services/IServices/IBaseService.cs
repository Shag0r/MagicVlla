using MagicVilla_Web_new.Models;

namespace MagicVilla_Web_new.Services.IServices
{
    public interface IBaseService
    {
         APIResponse responseModel { get; set; }
        //creating a method to call the api responses
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
