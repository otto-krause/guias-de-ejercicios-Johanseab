using System;
using System.Collections.Generic;
namespace E6
{
     class Program
    {
        static void Main(string[] args)
        {
            string Calificacion;
            string GeneroDelJuego;
            int num=0;
            while(num != 3)
            {
                Console.Write("ingrese: \n[1]Buscar juego por genero\n[2]Buscar juego por clasificacion\n[3]Para Salir\n");
                num = Int32.Parse(Console.ReadLine());
                steam Steam = new steam();
                switch(num)
                {
                     case 1:
                     Console.WriteLine("ingrese el genero del juego");
                     GeneroDelJuego = Console.ReadLine();
                     List<string> ListadoGenero = Steam.PorGenero(GeneroDelJuego);
                     foreach (var i in ListadoGenero)
                     {
                         Console.WriteLine(i);
                     } 
                     break;
                     case 2:
                     Console.WriteLine("ingrese la calificacion del juego");
                     Calificacion = Console.ReadLine();
                     List<string> ListadoCalificacion = Steam.PorCalificacion(Calificacion);
                     foreach (var i in ListadoCalificacion)
                     {
                         Console.WriteLine(i);
                     }
                     break;
                }
            }
        }
    }
}