using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
          string producto = "Fideos Marolio";
          int cantidadDelProducto = 2;

          Supermercado compra=new Supermercado(producto, cantidadDelProducto);
          Console.WriteLine("Las ganancias de el dia son: "+compra.Ganancias());  
        }
    }
}
