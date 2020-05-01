
using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        List<Producto> Productos = new List<Producto>();
        public Carrito()
        {
            Producto Arroz = new Producto("Dos Hermanos",45);
            Productos.Add(Arroz);
            Producto Fideos = new Producto("Lucchetti",50);
            Productos.Add(Fideos);
            Producto Pan = new Producto("Bimbo",70);
            Productos.Add(Pan);
        }
    }

}