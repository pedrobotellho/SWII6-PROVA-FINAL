using Microsoft.EntityFrameworkCore;
using SWII6_Prova2_API.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SWII6_Prova2_API
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().HasKey(m => m.Id);
            builder.Entity<Usuario>().HasKey(m => m.Id);

            base.OnModelCreating(builder);
        }
    }
}
