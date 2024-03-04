using charnteEV3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentre el método del pedido;
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal interface PedidoInterfaz
    {
        /// <summary>
        /// Método del pedido;
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public void pedido(List<PedidoDto> listaPedidos);
    }
}
