using System.Collections.Generic;
namespace E5
{
    public class Supermercado
    {
       List<Carrito> carritos = new List<Carrito>();
       string producto;
       int CantidadDelProducto;

       public Supermercado(string producto, int CantidadDelProducto)
       {
           this.producto = producto;
           this.CantidadDelProducto=CantidadDelProducto;
           Carrito carrito1= new Carrito();
           carritos.Add(carrito1);
       }
       public int Ganancia()
       {
           int precio=0;
           foreach (var i in carritos)
           {
               precio= i.precio(producto);
           }
           return precio*CantidadDelProducto;
       }
    }
}