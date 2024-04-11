using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Tutorial4.Models;
using Tutorial4.Database;

namespace VeterinaryClinicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitsController : ControllerBase
    {
        [HttpGet("{animalId}")]
        public ActionResult<List<Visit>> GetVisitsForAnimal(int animalId)
        {
            var visits = MockDb.Visits.Where(v => v.AnimalId == animalId).ToList();
            if (!visits.Any()) return NotFound("No visits found for the given animal.");
            return Ok(visits);
        }

        [HttpPost]
        public ActionResult<Visit> AddVisit([FromBody] Visit visit)
        {
            MockDb.Visits.Add(visit);
            return CreatedAtAction("GetVisitsForAnimal", new { animalId = visit.AnimalId }, visit);
        }
    }
}
