using charnteEV3.Dtos;
using charnteEV3.Servicios;

namespace charnteEV3.controladores
{
    /// <summary>
    /// Class program donde se encuentra el main de la aplicación.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método Main del programa donde se encuentran las llamadas a métodos, el switch, el while, etc
        /// <Author>CHI - 04/03/2024</Author>
        /// </summary>
        static void Main(string[] args)
        {

            MenuInterfaz menu = new MenuImplementacion();
            List<ProductoDto> producto = new List<ProductoDto>();
            List<PedidoDto> pedido = new List<PedidoDto>();
            OpInterfaz operaciones = new OpImplementacion();
            PedidoInterfaz pedir = new PedidoImplementacion();

            bool  cerrarMenu = false;

            while (!cerrarMenu)
            {
                int op = menu.menuP();

                switch(op)
                {

                    case 0:
                        Console.WriteLine("Se cierra el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        int op2 = menu.menuG();
                        switch(op2)
                        {
                            case 0:
                                Console.WriteLine("Se cierra el menú");
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Ventas en Ficheros");
                                break;
                            case 2:
                                Console.WriteLine("Crear Pedido para proveedores");
                                pedir.pedido(pedido);
                                break;
                            default:
                                Console.WriteLine("No es una opción válida");
                                break;

                         }
                        break;
                
                    case 2:
                        int op3 = menu.menuE();
                        switch (op3)
                        {
                            case 0:
                                Console.WriteLine("Se cierra el menú");
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Calculo de ventas");
                                operaciones.MostrarV(producto);
                                break;
                            case 2:
                                Console.WriteLine("Añadir ventas");
                                operaciones.AniadirV(producto);
                                break;
                            default:
                                Console.WriteLine("No es una opción válida");
                                break;

                     }
                     break;

                    default:
                        Console.WriteLine("No es una opción válida");
                        break;


                }

            }



        }


    }


}
