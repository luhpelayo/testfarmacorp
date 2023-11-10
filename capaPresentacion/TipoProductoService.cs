using capaAccesoDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogicaNegocio
{
    public class TipoProductoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TipoProductoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void RegistrarTipoProducto(TipoProducto tipoProducto)
        {
            // Lógica para registrar un TipoProducto...
            _unitOfWork.TiposProductoRepository.Add(tipoProducto);
            _unitOfWork.SaveChanges();
        }

        // Otros métodos para la lógica de negocios...
    }
}
