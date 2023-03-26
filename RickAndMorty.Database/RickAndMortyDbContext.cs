using Microsoft.EntityFrameworkCore;
using RickAndMorty.Database.Interface.Models;

namespace RickAndMorty.Database;

internal class ApplicationDbContext: DbContext
{
    public DbSet<Character> Characters { get; set; }

    private readonly string ConnectionString = @"Server=localhost;User=sa;
        Password=Pass@1234;
        Initial Catalog=RickAndMortyDb;
        Persist Security Info=False;Encrypt=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Character>()
            .Property(d => d.Id)
            .ValueGeneratedNever();
    }
}