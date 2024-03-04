using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Dtos
{
    /// <summary>
    /// Dto donde se encuentran los campos, getters y setters, etc de Pedidos.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal class PedidoDto
    {
        long id;

        string nombreProducto = "aaaaa";

        int cantidadProducto = 99;

        DateTime FechaEsperada = new DateTime(31/12/2000);


        

        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaEsperada1 { get => FechaEsperada; set => FechaEsperada = value; }
        public PedidoDto(long id, string nombreProducto, int cantidadProducto, DateTime fechaEsperada)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            FechaEsperada = fechaEsperada;
        }

        public PedidoDto() { }

        
           
           
            
    
    }
}
