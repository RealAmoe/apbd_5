using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        //GET
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            if (id != 1)
            {
                return Results.NotFound();
            }
            // process data
            return Results.Ok();
        });
        // 200 - Ok
        // 201 - Created
        // 400 - Bad Request
        // 404 - Not found

        //POST    
        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {
    
            // StaticData.animals.Add()
            return Results.Created("", animal);
        });
    }
}