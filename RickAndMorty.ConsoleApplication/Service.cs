using RickAndMorty.ConsoleApplication.Models;
using RickAndMorty.Database.Interface;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.ConsoleApplication;

public sealed class Service
{
    private readonly IRestApiClient client;
    private readonly IRepository repository;

    private static string[] validStatus = { "Alive" };

    public Service(IRestApiClient client, IRepository repository)
    {
        this.client = client;
        this.repository = repository;
    }

    public async Task Run() 
    {
        repository.Initialize();

        Console.WriteLine($"First page");
        var result = await client.Get(1);
        HandleResult(result);

        var pages = Enumerable.Range(2, result.Info.Pages - 1);

        var tasks = pages.Select(async page => {
            Console.WriteLine($"Page {page}");
            var result = await client.Get(page);
            HandleResult(result);
        });

        await Task.WhenAll(tasks);
    }

    private void HandleResult(Result<CharacterDto> result) 
    {
        var characters = new List<Character>();

        foreach(var dto in result.Results)  
        {
            Console.WriteLine($"{dto.Id}: {dto.Name}, {dto.Status}");
            if (validStatus.Contains(dto.Status)) 
            {
                characters.Add(dto.Map());
            }
        }

        if (characters.Count > 0)
        {
            repository.Save(characters);
        }
    }
}