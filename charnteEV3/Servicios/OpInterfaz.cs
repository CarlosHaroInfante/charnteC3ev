using charnteEV3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentran los métodos de mostrar menú, añadir y crear fichero.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal interface OpInterfaz
    {
        /// <summary>
        /// Método de añadir nueva venta.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public void AniadirV(List<ProductoDto> listaProducto);

        /// <summary>
        /// Método de añadir nueva venta.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public void MostrarV(List<ProductoDto> listaProducto);

        /// <summary>
        /// Método de añadir contenido a fichero.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public void MostrarF(List<ProductoDto> listaProducto);

    }
}
