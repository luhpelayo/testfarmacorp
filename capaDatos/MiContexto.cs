using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace capaDatos
{


    public class MiContexto : DbContext
    {
        public DbSet<TipoProducto> TiposProducto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ExpProducto> ExpProductos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones de Fluent API si es necesario...
        }
    }
}
