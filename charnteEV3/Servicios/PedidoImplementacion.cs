using charnteEV3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Clase donde se encuentran los métodos de pedido, e id Autoincremental.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal class PedidoImplementacion : PedidoInterfaz
    {
        public void pedido(List<PedidoDto> listaPedidos) {

            PedidoDto pedidoN = new PedidoDto();

            pedidoN.Id = idAutogenerado(listaPedidos);

            Console.WriteLine("Nombre del producto");
            pedidoN.NombreProducto = Console.ReadLine();

            Console.WriteLine("Cantidad de productos");
            pedidoN.CantidadProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fecha deseada de entrega");
            pedidoN.FechaEsperada1 = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("¿Deseas hacer un nuevo pedido? (Si(1) o No(0))");
            int volver = Convert.ToInt32(Console.ReadLine());

            if (volver == 1) { 
                pedidoN.Id = idAutogenerado(listaPedidos);

                Console.WriteLine("Nombre del producto");
                pedidoN.NombreProducto = Console.ReadLine();

                Console.WriteLine("Cantidad de productos");
                pedidoN.CantidadProducto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fecha deseada de entrega");
                pedidoN.FechaEsperada1 = Convert.ToDateTime(Console.ReadLine());

                }
            
            else
            {
                Console.WriteLine("No se desea hacer mas pedidos");
                foreach (PedidoDto pedidosN in listaPedidos)
                {
                    Console.WriteLine(pedidosN.NombreProducto.ToString());
                    Console.WriteLine(pedidosN.CantidadProducto.ToString());
                    Console.WriteLine(pedidosN.FechaEsperada1.ToString());

                   
                }
            }
            

             
        }

        private long idAutogenerado(List<PedidoDto> listaPedidos)
        {

            long id;

            int tamanio = listaPedidos.Count;

            if (listaPedidos.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = listaPedidos[tamanio - 1].Id + 1;

            }
            return id;
        }
    }
}
