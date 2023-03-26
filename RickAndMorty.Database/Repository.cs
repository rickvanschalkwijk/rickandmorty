using RickAndMorty.Database.Interface;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.Database;

public class Repository : IRepository
{
    public void Save(IList<Character> characters)
    {
        var db = new ApplicationDbContext();
        db.Characters.AddRange(characters);
        db.SaveChanges();
    }

    public void Save(Character character)
    {
        var db = new ApplicationDbContext();
        db.Characters.Add(character);
        db.SaveChanges();
    }

    public void CreateDatabase() 
    {
        var db = new ApplicationDbContext();
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
    }

    public void InitializeDatabase() 
    {
        var db = new ApplicationDbContext();
        db.Database.EnsureCreated();
    }

    public IList<Character> GetAll()
    {
        var db = new ApplicationDbContext();
        var x = db.Characters.ToList();
        return x;
    }
}