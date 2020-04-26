using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string Genero;
            int Año;
            string Director;
            int num=0;
            while(num != 7)
            {
            Console.WriteLine("ingrese \n1)Buscar por genero\n2)Buscar por nombre\n3)Buscar por año\n4)Buscar por director\n5)Saber cuantas peliculas hay en total\n6)Saber cuantas peliculas de un genero en especifico hay\n7)para salir");
            num = Int32.Parse(Console.ReadLine());
            Peliteca peliteca = new Peliteca();
            switch (num)
            {
                case 1:
                Console.WriteLine("ingrese el genero de la pelicula");
                Genero = Console.ReadLine();
                List<string> ListadoGenero = peliteca.PorGenero(Genero);
                foreach (var i in ListadoGenero)
                {
                    Console.WriteLine(i);
                }
                break;
                case 2:
                Console.WriteLine("ingrese el nombre de la pelicula");
                Nombre = Console.ReadLine();
                List<string> ListadoNombre = peliteca.PorNombre(Nombre);
                foreach (var i in ListadoNombre)
                {
                    Console.WriteLine(i);
                }
                break;  
                case 3:
                Console.WriteLine("ingrese el año de estreno de la pelicula");
                Año = Int32.Parse(Console.ReadLine());
                List<string> ListadoAño = peliteca.PorAño(Año);
                foreach (var i in ListadoAño)
                {
                    Console.WriteLine(i);
                }
                break;
                case 4:
                Console.WriteLine("ingrese el director de la pelicula");
                Director = Console.ReadLine();
                List<string> ListadoDirector = peliteca.PorDirector(Director);
                foreach (var i in ListadoDirector)
                {
                    Console.WriteLine(i);
                }
                break;
                case 5:
                Console.WriteLine("\n"+peliteca.TotalDePeliculas());
                break;
                case 6:
                Console.WriteLine("ingrese el genero de peliculas que desea saber");
                Genero = Console.ReadLine();
                Console.WriteLine("\n"+peliteca.ContarPeliculas(Genero));
                break;
            }
            }
        }
    }
}
