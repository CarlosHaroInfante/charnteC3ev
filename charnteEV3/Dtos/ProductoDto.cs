using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Dtos
{
    /// <summary>
    /// Dto donde se encuentran los campos, getters y setters, etc de Productos.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal class ProductoDto
    {
        long id;

        double precio = 99.99;

        DateTime fechaV;

        

        public long Id { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaV { get => fechaV; set => fechaV = value; }
        
        public ProductoDto(long id, double precio, DateTime fechaV)
        {
            this.id = id;
            this.precio = precio;
            this.fechaV = fechaV;
        }

        public ProductoDto() { }

    }
}
