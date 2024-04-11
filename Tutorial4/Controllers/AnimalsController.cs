using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;


namespace Tutorial4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Animal>> GetAnimals()
    {
        return Ok(MockDb.Animals);
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> GetAnimal(int id)
    {
        var animal = MockDb.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        return Ok(animal);
    }

    [HttpPost]
    public ActionResult<Animal> CreateAnimal([FromBody] Animal animal)
    {
        MockDb.Animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimal), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal updatedAnimal)
    {
        var animal = MockDb.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        animal.Name = updatedAnimal.Name;
        animal.Category = updatedAnimal.Category;
        animal.Weight = updatedAnimal.Weight;
        animal.FurColor = updatedAnimal.FurColor;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = MockDb.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        MockDb.Animals.Remove(animal);
        return NoContent();
    }
}
