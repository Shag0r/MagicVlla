using MagicVilla_Web_new.Models.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web_new.Models.VM
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillaNumberCreateDTO();
        }

        public VillaNumberCreateDTO VillaNumber { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> villalist { get; set; }
      
    }
}
