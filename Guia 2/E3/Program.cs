using System;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
         string NombreJugador;
         string Posicion;
         string PaisDelJugador;
         int NumDeFigurita;
         Console.WriteLine("ingrese el nombre del jugador: ");
         NombreJugador = Console.ReadLine();
         Console.WriteLine("ingrese la Posicion del jugador: ");
         Posicion = Console.ReadLine();
         Console.WriteLine("ingrese el Pais del jugador: ");
         PaisDelJugador = Console.ReadLine();
         Console.WriteLine("ingrese el numero de la figurita : ");
         NumDeFigurita = Int32.Parse(Console.ReadLine());
         Album album = new Album();
         Console.WriteLine("\n"+album.NuevaFigurita(NombreJugador,Posicion,PaisDelJugador,NumDeFigurita));
         Console.WriteLine("\n"+album.CuantosDelanteros());
         Console.WriteLine("\n"+album.CuantosMediocampostas());
         Console.WriteLine("\n"+album.EstaCompleto());
        }
    }
}
