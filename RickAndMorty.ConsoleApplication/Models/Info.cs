using System.Text.Json.Serialization;

namespace RickAndMorty.ConsoleApplication.Models;

public sealed record class Info(
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("pages")] int Pages,
    [property: JsonPropertyName("next")] Uri? Next,
    [property: JsonPropertyName("prev")] Uri? Prev)
{
    
}