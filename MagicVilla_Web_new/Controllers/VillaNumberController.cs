using AutoMapper;
using MagicVilla_Web_new.Models;
using MagicVilla_Web_new.Models.Dto;
using MagicVilla_Web_new.Models.VM;
using MagicVilla_Web_new.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Cli.Utils;
using Newtonsoft.Json;

namespace MagicVilla_Web_new.Controllers
{
    public class VillaNumberController : Controller
    {
        readonly IVillaNumberServices _villaNumberServices;
        readonly IVillaServices _villaServices;
        readonly IMapper _mapper;
        public VillaNumberController(IVillaNumberServices villaNumberServices, IMapper mapper, IVillaServices villaServices)
        {
            _villaNumberServices = villaNumberServices;
            _mapper = mapper;
            _villaServices = villaServices;

            
        }
        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();
            var response = await _villaNumberServices.GetAllAsync<APIResponse>();
            //if (response != null && response.IsSuccess)
            //{
            list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));

            //}
            return View(list);
        }

        public async Task<IActionResult> CreateVillaNumber()
        {
            VillaNumberCreateVM villaNumberVM = new();
            var response = await _villaServices.GetAllAsync<APIResponse>();
            villaNumberVM.villalist = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }); ;
            return View(villaNumberVM);
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVillaNumber(VillaNumberCreateVM model)
        {
            if (ModelState.IsValid)
            {
                // Call service method to create the villa number
                var response = await _villaNumberServices.CreatedAsynce<APIResponse>(model.VillaNumber);

                if (response != null && response.IsSuccess)
                {
                    // Redirect to the index action if creation is successful
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
                else
                {
                    // Handle error messages from the response, if any
                    ModelState.AddModelError("ErrorMessages", "Failed to create Villa Number. Please try again later.");
                }
            }

            // Populate the dropdown list of villas
            var resp = await _villaServices.GetAllAsync<APIResponse>();
            if (resp != null && resp.IsSuccess)
            {
                model.villalist = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(resp.Result))
                                    .Select(i => new SelectListItem
                                    {
                                        Text = i.Name,
                                        Value = i.Id.ToString()
                                    });
            }

            // Return the view with the updated model, including any validation errors
            return View(model);
        }







    }
}
