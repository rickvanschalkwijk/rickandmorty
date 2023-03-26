using System.Text.Json.Serialization;

namespace RickAndMorty.ConsoleApplication.Models;

public sealed record class LocationDto(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("url")] Uri Url)
{
    
}