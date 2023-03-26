// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var service = new RickAndMorty.ConsoleApplication.Service(
    new RickAndMorty.ConsoleApplication.RestApiClient(),
    new RickAndMorty.Database.Repository()
);
service.Run().Wait();
