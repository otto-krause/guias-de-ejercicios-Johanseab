using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace E1
{
    public static class ComandosPeliculas
    {
        public static void ingresarPeliculas(string pelicula)
        {
            StreamWriter fichero;

            fichero=File.AppendText("peliculas.txt");
            fichero.WriteLine(pelicula);
            fichero.Close();   
        }
        public static void verTodasLasPeliculas()
        {
            string linea;
            StreamReader fichero;

            fichero=File.OpenText("peliculas.txt");

            do
            {
                linea=fichero.ReadLine();
                Console.WriteLine(linea);
            }
            while(linea!=null);
        }
        public static void verTodasLasPeliculasSinRepetir()
        {
            string linea;
            List<String> todasLasPeliculas=new List<string>();
            StreamReader fichero;

            fichero=File.OpenText("peliculas.txt");

            do
            {
            linea=fichero.ReadLine();
            todasLasPeliculas.Add(linea);
            }
            while(linea!=null);

            todasLasPeliculas.Distinct()
            .ToList()
            .ForEach(numero=>Console.WriteLine(numero));
        }
        public static void consultarUnaPelicula(string peliculaConsultada)
        {
            string linea;
            StreamReader fichero;
            fichero=File.OpenText("peliculas.txt");

            do
            {
                linea=fichero.ReadLine();
                if(linea==peliculaConsultada)
                Console.WriteLine("Si se encuentra la pelicula");
            }
            while(linea!=null);
        }
    }
}