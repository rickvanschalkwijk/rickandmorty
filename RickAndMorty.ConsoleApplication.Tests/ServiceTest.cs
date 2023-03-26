using Moq;
using RickAndMorty.ConsoleApplication.Models;
using RickAndMorty.Database.Interface;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.ConsoleApplication.Tests;

public class ServiceTest
{
    private Mock<IRestApiClient> client = new Mock<IRestApiClient>();
    private Mock<IRepository> repository = new Mock<IRepository>();

    [Fact]
    public async Task ShouldRunAsync()
    {

        var info = new Info(2, 2, null, null);

        var page1 = new CharacterDto[]
        {
            new CharacterDto (
                1,
                "name1",
                "Alive",
                "species1",
                "type1",
                "gender1",
                new LocationDto("origin1", new Uri("https://origin1")),
                new LocationDto("location1", new Uri("https://location1")),
                new Uri("https://image1"),
                new Uri[]
                {
                    new Uri("https://episode/1"),
                    new Uri("https://episode/2"),
                },
                new Uri("https://url1/"),
                new DateTime(2023, 3, 25)
            )
        };

        var page2 = new CharacterDto[]
        {
            new CharacterDto (
                2,
                "name2",
                "status2",
                "species2",
                "type2",
                "gender2",
                new LocationDto("origin2", new Uri("https://origin")),
                new LocationDto("location2", new Uri("https://location")),
                new Uri("https://image2"),
                new Uri[]
                {
                    new Uri("https://episode/1"),
                    new Uri("https://episode/2"),
                },
                new Uri("https://url2/"),
                new DateTime(2023, 3, 25)
            )
        };

        client.Setup(c => c.Get(1)).ReturnsAsync(
            new Result<CharacterDto>(info, page1)
        );

        client.Setup(c => c.Get(2)).ReturnsAsync(
            new Result<CharacterDto>(info, page2)
        );

        var service = new Service(client.Object, repository.Object);
        await service.Run();

        client.VerifyAll();
        repository.Verify(r => r.Save(
            It.Is<IList<Character>>(a =>
                a.Count == 1 &&
                a[0].Name == "name1"
            )
        ), Times.Once());
    }
}