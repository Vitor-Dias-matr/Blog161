using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Blog161.Models;

public class BlogContext : IdentityDbContext<User>
{
    public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
    {
    }

    public DbSet<User> BlogUsers { get; set; }

    public DbSet<Blog161.Models.Mensagem> Mensagem { get; set; }

    public DbSet<Blog161.Models.Comentario> Comentario { get; set; }

    public DbSet<Blog161.Models.Categoria> Categoria { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
