using System.Text.Json.Serialization;

namespace RickAndMorty.ConsoleApplication.Models;

public sealed record class Result<T>(
    [property: JsonPropertyName("info")] Info Info,
    [property: JsonPropertyName("results")] T[] Results)
{
}