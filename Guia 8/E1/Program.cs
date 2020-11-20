using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pelicula;

            Console.WriteLine("Ingresar el nombre de un pelicula");
            pelicula=Console.ReadLine();

            ComandosPeliculas.ingresarPeliculas(pelicula);
            ComandosPeliculas.verTodasLasPeliculas(); 
            ComandosPeliculas.verTodasLasPeliculasSinRepetir();
        }
    }
}
