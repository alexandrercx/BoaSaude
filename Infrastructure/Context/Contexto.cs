using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Associado> Associados { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<PlanoFaixaEtaria> PlanoFaixaEtarias { get; set; }
        public DbSet <AssociadoPlano> AssociadoPlanos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<ContaBanco> ContaBancos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
          

            modelBuilder.Entity<Associado>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Associado>().Property(r => r.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Endereco>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Endereco>().Property(r => r.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Associado>().HasMany(p => p.enderecos).WithOne().HasForeignKey(p => p.AssociadoId);






            base.OnModelCreating(modelBuilder);
        }
    }
}
