using System.ComponentModel.DataAnnotations;

namespace MagicVlla_VillaAPI.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int villaNo { get; set; }
        
        [Required]
        public int villaID { get; set; }
        public string SpecialDetailes { get; set; }
    }
}
