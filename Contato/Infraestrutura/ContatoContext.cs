using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Infraestrutura
{
    public class ContatoContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=ContatosDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>(c =>
            {
                c.ToTable("TBContato");

                c.HasKey(p => p.Id);
                c.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
                c.HasMany(p => p.Telefones).WithOne(p => p.contato);

            });
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
