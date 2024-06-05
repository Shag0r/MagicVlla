using MagicVlla_VillaAPI.Data;
using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVlla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            //creating end point
            var test = VillaStore.villaList;
            return Ok(test);
        }
        [HttpGet("{id:int}",Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status208AlreadyReported)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
         public ActionResult GetVillabyId(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            if (villa == null)
            {
                return NoContent();
            }
          
            return Ok(villa);
        }

        //creating post request
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status208AlreadyReported)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDto) {
            if (villaDto == null)
            {
                return BadRequest();
            }
            //if id is greater than zero then it is not a create request. as Id will generated autometically so id needs not to be inserted
            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            villaDto.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDto);

             //return Ok(villaDto);
            return CreatedAtRoute("GetVilla",new { id=villaDto.Id}, villaDto);
        }
        // creating a delete request

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            VillaStore.villaList.Remove(villa);
            return NoContent();
        }


        //creating a put request
        [HttpPut("{id:int}",Name ="UpdateWithPut")]
        public IActionResult UpdateWithPut(int id, [FromBody] VillaDTO villaDto)
        {
            if(villaDto==null || id != villaDto.Id)
            {
                return BadRequest();
            }
            var  villa= VillaStore.villaList.FirstOrDefault(u=>u.Id == id);
            villa.Name= villaDto.Name;
            villa.Occupancy= villaDto.Occupancy;
            villa.sqft= villaDto.sqft;


            return Ok(villa);

        }

        //creating a patch request
        //patch is used to update only the specficiq property
        [HttpPatch("{id:int}",Name ="UpdateWithPatch")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult UpdateWithPatch(int id, JsonPatchDocument<VillaDTO> patchDto)
        {
            if(patchDto==null || id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if (villa == null) { return BadRequest(); }
            patchDto.ApplyTo(villa,ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(villa);
        }
       




    }
}
