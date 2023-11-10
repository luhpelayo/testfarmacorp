using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDeDatos
{
    public interface ITipoProductoRepository
    {
        void Add(TipoProducto tipoProducto);
        // Otros métodos del repositorio...
    }
}
