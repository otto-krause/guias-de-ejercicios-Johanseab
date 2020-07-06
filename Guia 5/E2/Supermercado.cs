using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Supermercado
    {
      List<Carrito> carritos = new List<Carrito>();
      string producto;
      int cantidadaDelProducto;

      public Supermercado(string producto, int cantidadaDelProducto)
      {
          this.producto=producto;
          this.cantidadaDelProducto=cantidadaDelProducto;

          Carrito c1= new Carrito();
          carritos.Add(c1);
      }  
      public int Ganancias()
      {
          int ganancias=0;
          carritos.ForEach(precios => ganancias = precios.precio(producto));
          return ganancias*cantidadaDelProducto;
      }  
    }
}