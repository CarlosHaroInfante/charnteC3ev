using charnteEV3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnteEV3.Servicios
{
    /// <summary>
    /// Clase donde se encuentran los métodos de mostrar menú, añadir y crear fichero.
    /// <Author>CHI - 04/03/2024</Author>
    /// </summary>
    internal class OpImplementacion : OpInterfaz
    {

        public void AniadirV(List<ProductoDto> listaProducto) {

            ProductoDto venta = new ProductoDto();
            Console.WriteLine("Añadir venta");
            venta.Id = idAutogenerado(listaProducto);

            Console.WriteLine("Precio");
            venta.Precio = Convert.ToDouble(Console.ReadLine());

            venta.FechaV = Convert.ToDateTime(DateTime.Now);
            Console.WriteLine(venta.FechaV);

            listaProducto.Add(venta);

        }
        public void MostrarV(List<ProductoDto> listaProducto)
        {
            ProductoDto fchVenta = new ProductoDto();
            Console.WriteLine("Dame la fecha del día de las ventas");
            DateTime fechaVenta = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(fchVenta.FechaV);
            foreach (ProductoDto calculo in listaProducto)
            {
                if ((calculo.FechaV.Year.Equals(fechaVenta.Year) && calculo.FechaV.Month.Equals(fechaVenta.Month)
                    && calculo.FechaV.Day.Equals(fechaVenta.Day)))
                {
                    /*double precio = listaProducto[0].Precio;
                    double precio2 = listaProducto[i++].Precio;*/
                    double aux;


                    for (int i = 0; i < listaProducto.Count; i++)
                    {
                        for (int j = 0; j < listaProducto.Count - 1; j++)
                        {
                            double aux2;

                            aux = listaProducto[j].Precio;
                            listaProducto[j].Precio = listaProducto[j + 1].Precio;
                            listaProducto[j + 1].Precio = aux;

                            aux2 = listaProducto[j].Precio;

                            double total = aux + aux2;

                            Console.WriteLine(total);

                            int diffHoras = listaProducto[j].FechaV.Hour - listaProducto[j + 1].FechaV.Hour;
                            Console.WriteLine(diffHoras);
                            int diffMin = listaProducto[j].FechaV.Minute - listaProducto[j + 1].FechaV.Minute;
                            Console.WriteLine(diffMin);
                            int diffSeg = listaProducto[j].FechaV.Second - listaProducto[j + 1].FechaV.Second;
                            Console.WriteLine(diffSeg);


                            listaProducto.Add(fchVenta);

                        }
                    }

                }
            }


        }

        public void MostrarF(List<ProductoDto> listaProducto)
        {
            ProductoDto producto = new ProductoDto();
            Console.WriteLine("Dame la fecha del día de las ventas");
            DateTime fechaVenta = Convert.ToDateTime(Console.ReadLine());

            foreach (ProductoDto calculo in listaProducto)
            {
                if (calculo.FechaV.Year.Equals(fechaVenta.Year) && calculo.FechaV.Month.Equals(fechaVenta.Month)
                    && calculo.FechaV.Day.Equals(fechaVenta.Day))
                {
                    /*double precio = listaProducto[0].Precio;
                    double precio2 = listaProducto[i++].Precio;*/
                    double aux;


                    for (int i = 0; i < listaProducto.Count; i++)
                    {
                        for (int j = 0; j < listaProducto.Count - 1; j++)
                        {
                            

                            aux = listaProducto[j].Precio;
                            listaProducto[j].Precio = listaProducto[j + 1].Precio;
                            listaProducto[j + 1].Precio = aux;

                            string nombre = "ddMMyyyy.txt";

                            using(StreamWriter sw = new StreamWriter(nombre, true)) 
                            {
                                sw.WriteLine("...........");
                                sw.WriteLine("Venta número: " + producto.Id + "/n");
                                sw.WriteLine("Euros: " + producto.Precio + "/n");
                                sw.WriteLine("Instante de compra: " + producto.FechaV + "/n");
                                sw.WriteLine("...........");

                            }

                           





                        }
                    }

                }
            }
        }

            private long idAutogenerado(List<ProductoDto> listaProducto)
            {

                long id;

                int tamanio = listaProducto.Count;

                if (listaProducto.Count == 0)
                {
                    id = 1;
                }
                else
                {
                    id = listaProducto[tamanio - 1].Id + 1;

                }
                return id;
            }
        }
    }


