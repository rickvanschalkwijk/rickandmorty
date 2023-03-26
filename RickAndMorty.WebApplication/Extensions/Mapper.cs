using RickAndMorty.WebApplication.Models;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.WebApplication.Extensions;

public static class Mapper 
{
    public static CharacterModel Map(this Character entity)
    {
        return new CharacterModel() 
        {
            Name = entity.Name,
            Species = entity.Species,
            Type = entity.Type,
            Gender = entity.Gender,
            Origin = entity.Origin,
            Location = entity.Location
        };
    }

    public static CharacterModel[] Map(this IList<Character> entities)
    {
        return entities.ToList().ConvertAll(e => e.Map()).ToArray();
    }

    public static Character Map(this CharacterModel model)
    {
        return new Character()
        {
            Name = model.Name,
            Species = model.Species,
            Type = model.Type,
            Gender = model.Gender,
            Origin = model.Origin,
            Location = model.Location
        };
    }

}