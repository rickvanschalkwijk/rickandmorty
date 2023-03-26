using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.Database.Interface;

public interface IRepository
{
    void InitializeDatabase();
    void CreateDatabase();
    void Save(IList<Character> characters);
    void Save(Character characters);
    IList<Character> GetAll();
}
