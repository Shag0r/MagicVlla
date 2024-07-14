using AutoMapper;
using MagicVilla_Web_new.Models;
using MagicVilla_Web_new.Models.Dto;
using MagicVilla_Web_new.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace MagicVilla_Web_new.Controllers
{
    public class VillaController : Controller   
    {
        private readonly IVillaServices _villaServices;
        readonly IMapper _mapper;
        public VillaController(IVillaServices villaServices, IMapper mapper)
        {
            _villaServices = villaServices;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();
            var response = await _villaServices.GetAllAsync<APIResponse>();
            //if (response != null && response.IsSuccess)
            //{
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));

            //}
            return View(list);
        }
        public async Task<IActionResult> CreateVilla()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVilla(VillaCreateDTO model)
        {
            if (ModelState.IsValid) {
                var response = await _villaServices.CreatedAsynce<APIResponse>(model);
                return RedirectToAction(nameof(IndexVilla));

            }
            return View(model);
            

        }
        public async Task<IActionResult> UpdateVilla(int villaid)
        {
            //if (!ModelState.IsValid)
            //{
                var response = await _villaServices.GetAsync<APIResponse>(villaid);
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<VillaUpdateDTO>(model));
            //}

            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVilla(VillaUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaServices.UpdateAsync<APIResponse>(model);
                return RedirectToAction(nameof(IndexVilla));

            }
            return View(model);


        }


        //now for the delete
       
        public async Task<IActionResult> DeleteVilla(int villaid)
        {

            //var response = await _villaServices.GetAsync<APIResponse>(villaid);
            //VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
            //return View(model);
            var response = await _villaServices.GetAsync<APIResponse>(villaid);
            if (response != null)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();



        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteVilla(VillaDTO model)
        //{

        //   // var response = await _villaServices.DeleteAsync<APIResponse>(model.Id);
        //    await _villaServices.RemoveAsync(model.Id); // Directly call RemoveAsync
        //    return RedirectToAction(nameof(IndexVilla));







        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVillaConfirmed(VillaDTO model)
        {
           var response= await _villaServices.DeleteAsync<APIResponse>(model.Id);
         
            return RedirectToAction(nameof(IndexVilla));
        }
    }
    
}
