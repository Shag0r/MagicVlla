using AutoMapper;
using MagicVilla_Web_new.Models;
using MagicVilla_Web_new.Models.Dto;
using MagicVilla_Web_new.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MagicVilla_Web_new.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVillaServices _villaServices;
        readonly IMapper _mapper;
        public HomeController(IVillaServices villaServices, IMapper mapper)
        {
            _villaServices = villaServices;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();
            var response = await _villaServices.GetAllAsync<APIResponse>();
            //if (response != null && response.IsSuccess)
            //{
            list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));

            //}
            return View(list);
        }

    
    }
}
