using Permuta.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permuta.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {

        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(DbModelBuilder Model)
        {
            Database.SetInitializer<EfDbContext>(null);

            Model.Conventions.Remove<PluralizingTableNameConvention>();

            Model.Entity<Anuncio>().ToTable("TbAnuncio");

            Model.Entity<Cliente>().ToTable("TbCliente");

            Model.Entity<Categoria>().ToTable("TbCategoria");

        }
    }
}
