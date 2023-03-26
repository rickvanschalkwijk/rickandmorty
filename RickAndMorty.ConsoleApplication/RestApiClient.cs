using RickAndMorty.ConsoleApplication.Models;
using System.Text.Json;

namespace RickAndMorty.ConsoleApplication;

public sealed class RestApiClient : IRestApiClient
{
    static readonly HttpClient client = new HttpClient();
    private static string URL = "https://rickandmortyapi.com/api/character";

    public async Task<Result<CharacterDto>> Get(int page) 
    {
        await using Stream stream = await client.GetStreamAsync($"{URL}?page={page}");
        var result = await JsonSerializer.DeserializeAsync<Result<CharacterDto>>(stream);
        return result ?? new(new Info(0, 0, null, null), Array.Empty<CharacterDto>());
    }
}