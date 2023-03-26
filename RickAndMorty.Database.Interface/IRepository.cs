using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.Database.Interface;

public interface IRepository
{
    void Initialize();
    void Save(IList<Character> characters);
}
