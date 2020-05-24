
using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        List<Producto> productos = new List<Producto>();
        public Carrito()
        {
            Producto producto1 = new Producto("Arroz Dos Hermanos",45);
            productos.Add(producto1);
            Producto producto2= new Producto("Fideos Lucchetti",64);
            productos.Add(producto2);
        }
        public int precio(string producto)
        {
            foreach (var i in productos)
            {
                if(producto == i.getNombre())
                {
                    return i.getPrecio();
                }
            }
            return 0;
        }
    }

}