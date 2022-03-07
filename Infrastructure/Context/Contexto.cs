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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            base.OnModelCreating(modelBuilder);    
        }
    }
}
