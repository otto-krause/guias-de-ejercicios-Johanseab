using System.Collections.Generic;
using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
           string producto = " ";
           int CantidadDelProducto=0;
           Console.WriteLine("Ingrese el producto comprado y la cantidad");
           producto=Console.ReadLine();
           CantidadDelProducto=Int32.Parse(Console.ReadLine());
           Supermercado compra = new Supermercado(producto,CantidadDelProducto);
           Console.WriteLine("las ganancias del dia son: "+compra.Ganancia());
        }
    }
}
