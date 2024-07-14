using static MagicVilla_Utility.SD;

namespace MagicVilla_Web_new.Models
{
    public class APIRequest
    {
        public ApiType Apitype { get; set; }=ApiType.GET;
        //url for of the api
        public string Url {  get; set; }

        //Data of the api
        public object Data {  get; set; }
    }
}
