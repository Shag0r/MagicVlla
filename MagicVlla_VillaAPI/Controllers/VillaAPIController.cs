using MagicVlla_VillaAPI.Data;

using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVlla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {

        private readonly ApplicationDBContext _db;



        public VillaAPIController(ApplicationDBContext db)
        {
          _db = db;

            
        }


        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
           
            //creating end point
            var test = _db.Villas.ToList();
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
            var villa = _db.Villas.FirstOrDefault(x => x.Id == id);
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
            Villa model = new()
            {
                Amenity = villaDto.Amenity,
                Description = villaDto.Description,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                sqft = villaDto.sqft,
                Id = villaDto.Id,
                ImageUrl = villaDto.ImageUrl,

            };
            _db.Villas.Add(model);
            _db.SaveChanges();

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
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NoContent();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
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
            Villa model = new()
            {
                Amenity = villaDto.Amenity,
                Description = villaDto.Description,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                sqft = villaDto.sqft,
                Id = villaDto.Id,
                ImageUrl = villaDto.ImageUrl,

            };
            _db.Villas.Update(model);
            _db.SaveChanges();
            


            return Ok();

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
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
            VillaDTO villaDTO = new()
            {
                Amenity = villa.Amenity,
                Description = villa.Description,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                sqft = villa.sqft,
                Id = villa.Id,
                ImageUrl = villa.ImageUrl,

            };
            if (villa == null) { return BadRequest(); }
            patchDto.ApplyTo(villaDTO, ModelState);
            Villa model= new Villa(){
                Amenity = villa.Amenity,
                Description = villa.Description,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                sqft = villa.sqft,
                Id = villa.Id,
                ImageUrl = villa.ImageUrl,

            };
            _db.Villas.Update(model);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return NoContent();
        }
       




    }
}
