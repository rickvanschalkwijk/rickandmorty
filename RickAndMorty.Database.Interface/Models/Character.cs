namespace RickAndMorty.Database.Interface.Models;

public sealed record class Character
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Species { get; set; }
    public string? Type { get; set; }
    public string? Gender { get; set; }
    public string? Origin { get; set; }
    public string? Location { get; set; }
    public ICollection<Episode>? Episode { get; set; }
    public DateTime Created { get; set; }
}