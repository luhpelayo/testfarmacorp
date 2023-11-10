using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDeDatos
{
    public class TipoProductoRepository : ITipoProductoRepository
    {
        private readonly MiContexto _contexto;

        public TipoProductoRepository(MiContexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(TipoProducto tipoProducto)
        {
            _contexto.TiposProducto.Add(tipoProducto);
        }

        // Otros métodos del repositorio...
    }
}
