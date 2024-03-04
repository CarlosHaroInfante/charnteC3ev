using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentran los métodos de los menús.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método donde se encuentra el menú principal.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public int menuP();

        /// <summary>
        /// Método donde se encuentra el menú de gerentes.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public int menuG();

        /// <summary>
        /// Método donde se encuentra el menú de empleados.
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        public int menuE();
    }
}
