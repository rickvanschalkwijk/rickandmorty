using RickAndMorty.ConsoleApplication.Extensions;
using RickAndMorty.ConsoleApplication.Models;

namespace RickAndMorty.ConsoleApplication.Tests.Extensions;

public class MapperTest
{
    [Fact]
    public void ShouldMapDefaultInstance()
    {
        var dto = new CharacterDto(
            1,
            "name",
            "status",
            "species",
            "type",
            "gender",
            new LocationDto("origin", new Uri("https://origin")),
            new LocationDto("location", new Uri("https://location")),
            new Uri("https://image"),
            new Uri[] 
            {
                new Uri("https://episode/1"),
                new Uri("https://episode/2"),
            },
            new Uri("https://url/"),
            new DateTime(2023, 3, 25));

        var entity = dto.Map();

        Assert.Equal("name", entity.Name);
        Assert.Equal("species", entity.Species);
        Assert.Equal("type", entity.Type);
        Assert.Equal("gender", entity.Gender);
        Assert.Equal("origin", entity.Origin);
        Assert.Equal("location", entity.Location);
        Assert.Equal(2, entity.Episode?.Count);
        Assert.Equal("Episode 1", entity.Episode?.ToList()[0].Name);
        Assert.Equal("Episode 2", entity.Episode?.ToList()[1].Name);
        Assert.Equal(new DateTime(2023, 3, 25), entity.Created);
    }

    [Fact]
    public void ShouldMapInstanceWithoutEpisodes()
    {
        var dto = new CharacterDto(
            1,
            "name",
            "status",
            "species",
            "type",
            "gender",
            new LocationDto("origin", new Uri("https://origin")),
            new LocationDto("location", new Uri("https://location")),
            new Uri("https://image"),
            Array.Empty<Uri>(),
            new Uri("https://url/"),
            new DateTime(2023, 3, 25));

        var entity = dto.Map();

        Assert.Equal("name", entity.Name);
        Assert.Equal("species", entity.Species);
        Assert.Equal("type", entity.Type);
        Assert.Equal("gender", entity.Gender);
        Assert.Equal("origin", entity.Origin);
        Assert.Equal("location", entity.Location);
        Assert.Equal(0, entity.Episode?.Count);
        Assert.Equal(new DateTime(2023, 3, 25), entity.Created);
    }
}