using System.Text.Json.Serialization;

namespace RickAndMorty.ConsoleApplication.Models;

public sealed record class CharacterDto(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("species")] string Species,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("gender")] string Gender,
    [property: JsonPropertyName("origin")] LocationDto Origin,
    [property: JsonPropertyName("location")] LocationDto Location,
    [property: JsonPropertyName("image")] Uri Image,
    [property: JsonPropertyName("episode")] Uri[] Episodes,
    [property: JsonPropertyName("url")] Uri Url,
    [property: JsonPropertyName("created")] DateTime Created)
{
    
}