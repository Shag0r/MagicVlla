using System.Net;

namespace MagicVlla_VillaAPI.Models
{
    public class APIResponse
    {
        //http status code type based on its responses 
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } 
        public List<string> ErrorMassages { get; set; }
        public object Result {  get; set; }

    }
}
