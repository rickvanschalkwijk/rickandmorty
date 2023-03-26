using RickAndMorty.ConsoleApplication.Models;

namespace RickAndMorty.ConsoleApplication;

public interface IRestApiClient
{
    Task<Result<CharacterDto>> Get(int page);
}