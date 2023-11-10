using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDeDatos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MiContexto _contexto;

        public ITipoProductoRepository TiposProductoRepository { get; }

        // Otros repositorios...

        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
