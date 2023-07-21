using Microsoft.EntityFrameworkCore;
using WebApiDatabaseFirst.Models;

namespace WebApiDatabaseFirst.Context;

public partial class FilmeContext : DbContext
{
    public FilmeContext()
    {
    }

    public FilmeContext(DbContextOptions<FilmeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Filme> Filmes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MsSqlLocalDb;Database=FilmesDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>(entity =>
        {
            entity.Property(e => e.Diretor).HasMaxLength(100);
            entity.Property(e => e.Genero).HasMaxLength(50);
            entity.Property(e => e.Nome).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
