using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    public AnimalsController()
    {
        
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        // var animals = StaticData.animals;
        
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
}