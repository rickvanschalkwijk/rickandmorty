using RickAndMorty.ConsoleApplication.Models;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.ConsoleApplication.Extensions;

public static class Mapper
{
    public static Character Map(this CharacterDto dto)
    {
        return new Character() 
        {
            Name = dto.Name,
            Species = dto.Species,
            Type = dto.Type,
            Gender = dto.Gender,
            Origin = dto.Origin.Name,
            Location = dto.Location.Name,
            Episode = dto.Episodes.Map(),
            Created = dto.Created
        };
    }

    private static ICollection<Episode> Map(this Uri[] episodes)
    {
        return episodes.ToList().ConvertAll(e => new Episode() {
            Name = $"Episode {e.Segments.LastOrDefault()}"
        }) ?? new List<Episode>() { };
    }

}