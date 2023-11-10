using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDeDatos
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoProductoRepository TiposProductoRepository { get; }

        // Otros repositorios...

        int SaveChanges();
    }

}
