using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public static List<Animal> Animals = new List<Animal>();
    public static List<Visit> Visits = new List<Visit>();

    public MockDb()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}