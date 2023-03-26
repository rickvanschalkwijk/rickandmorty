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

    public void Initialize() 
    {
        var db = new ApplicationDbContext();
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
    }
}