using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Carrito
    {
      List<Producto> productos = new List<Producto>();
      public Carrito()
      {
          Producto p1 = new Producto("Fideos Marolio", 40);
          Producto p2 = new Producto("Oreos", 60);
          productos.Add(p1);
          productos.Add(p2);
      }  
      public int precio(string producto)
      {
        int ganancias = 0;
        List<Producto> precios=productos.Where(Producto=> producto == Producto.Nombre).ToList();
        precios.ForEach(precio => ganancias = precio.Precio);
        return ganancias;  
      }
    }
}