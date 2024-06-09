using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVlla_VillaAPI.Models
{
    public class VillaNumber
    {
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int villaNo {  get; set; }

      
        public int villaID { get; set; }
        [ForeignKey("villaID")]
        [ValidateNever]

        public Villa? Villa { get; set; }


        public string SpecialDetailes {  get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}
