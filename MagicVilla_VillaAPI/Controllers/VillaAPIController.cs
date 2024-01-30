using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            IEnumerable<Villa> villas = _db.Villas.ToList();
            return Ok(villas);
        }

        [HttpGet("id", Name ="GetVilla")]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0) return BadRequest();
            var villa = _db.Villas.FirstOrDefault(x => x.Id == id);
            if (villa == null) return NotFound();
            return Ok(villa);
        }

        [HttpPost]
        public ActionResult<VillaDto> Create([FromBody]VillaDto villaDto)
        {
            if (villaDto == null) return BadRequest();
            if (villaDto.Id > 0) return StatusCode(StatusCodes.Status500InternalServerError);

            Villa villaModel = new()
            {
                Id = villaDto.Id,
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                ImageUrl = villaDto.ImageUrl,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Sqft = villaDto.Sqft,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _db.Villas.Add(villaModel);
            _db.SaveChanges();

            return CreatedAtRoute("GetVilla", new { id = villaDto.Id } ,villaDto);
        }

        [HttpPut("id")]
        public IActionResult Update(int id, [FromBody]VillaDto villaDto)
        {
            if (villaDto == null) return BadRequest();
            var villa = _db.Villas.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if(villa == null) return NotFound();

            Villa villaModel = new()
            {
                Id = villaDto.Id,
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                ImageUrl = villaDto.ImageUrl,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Sqft = villaDto.Sqft,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _db.Villas.Update(villaModel);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPatch("id", Name ="UpdatePartialVilla")]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDto> patchDto)
        {
            if (patchDto == null) return BadRequest();
            var villa = _db.Villas.AsNoTracking().FirstOrDefault(x => x.Id == id);

            VillaDto villaDto = new()
            {
                Id = villa.Id,
                Amenity = villa.Amenity,
                Details = villa.Details,
                ImageUrl = villa.ImageUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqft = villa.Sqft,
            };

            if (villa == null) return NotFound();
            patchDto.ApplyTo(villaDto, ModelState);

            Villa villaModel = new()
            {
                Id = villaDto.Id,
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                ImageUrl = villaDto.ImageUrl,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Sqft = villaDto.Sqft,
            };

            _db.Villas.Update(villaModel);
            _db.SaveChanges();

            if(!ModelState.IsValid) return BadRequest(ModelState);

            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {            
            var villa = _db.Villas.FirstOrDefault(x => x.Id == id);
            if (villa == null) return BadRequest();

            _db.Villas.Remove(villa);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
