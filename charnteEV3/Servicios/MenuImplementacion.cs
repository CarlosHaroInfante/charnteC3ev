using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Clase donde se encuentran los menús.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuP() {
            Console.WriteLine("Menú de plantilla");
            Console.WriteLine("/////////////////");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Menú Gerente");
            Console.WriteLine("[2] - Menú Empleado");
            Console.WriteLine("/////////////////");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }


        public int menuG() {

            Console.WriteLine("Menú de Gerentes");
            Console.WriteLine("/////////////////");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Ventas del día (en fichero)");
            Console.WriteLine("[2] - Crear pedido para proveedores");
            Console.WriteLine("/////////////////");

            int op2 = Convert.ToInt32(Console.ReadLine());

            return op2;


        }

        public int menuE() {

            Console.WriteLine("Menú de Empleados");
            Console.WriteLine("/////////////////");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Cálculo total de ventas diario");
            Console.WriteLine("[2] - Añadir venta");
            Console.WriteLine("/////////////////");

            int op3 = Convert.ToInt32(Console.ReadLine());

            return op3;

        }
    }
}
