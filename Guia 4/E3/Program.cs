﻿using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            
            string nombreDelJuego;
            int añoDeLanzamiento;
            string nombreDeLaConsola;
            int horasJugadas;
            Jugador marito = new Jugador("Marito");
            while(opcion != "Salir")
            {
                Console.WriteLine(
                    "[1]Adquirir un juego\n"+
                    "[2]Ver el juego mas nuevo\n"+
                    "[3]Ver el juego mas viejo\n"+
                    "[4]Ver la consola mas usada\n"+
                    "[5]Jugar en una consola");
                opcion=Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                    Console.WriteLine("Ingrese el nombre del juego, año de lanzamiento y nombre de la consola");
                    nombreDelJuego=Console.ReadLine();
                    añoDeLanzamiento=Int32.Parse(Console.ReadLine());
                    nombreDeLaConsola=Console.ReadLine();
                    Juego juego=new Juego(nombreDelJuego,añoDeLanzamiento,nombreDeLaConsola);
                    marito.adquirirJuego(juego);
                    break;
                    case "2":
                    Console.WriteLine("Ingrese el nombre de la consola de la que deasea saber el juego mas reciente");
                    nombreDeLaConsola=Console.ReadLine();
                    foreach (var i in marito.Consolas)
                    {
                        if(nombreDeLaConsola==i.ToString())Console.WriteLine("El juego mas nuevo es: "+i.elMasNuevo());
                    }
                    break;
                    case "3":
                    Console.WriteLine("Ingrese el nombre de la consola de la que desea saber el juego mas viejo");
                    nombreDeLaConsola=Console.ReadLine();
                    foreach (var i in marito.Consolas)
                    {
                        if(nombreDeLaConsola==i.ToString())Console.WriteLine("El juego mas viejo es: "+i.elMasViejo());
                    }
                    break;
                    case "4":
                    Console.WriteLine(marito.laMasUsada());
                    break;
                    case "5":
                    Console.WriteLine("Ingrese el nombre de la consola en la que desea jugar y las horas que jugo");
                    nombreDeLaConsola=Console.ReadLine();
                    horasJugadas=Int32.Parse(Console.ReadLine());
                    foreach (var i in marito.Consolas)
                    {
                        if(nombreDeLaConsola==i.ToString()) i.jugar(horasJugadas);
                    }  
                    break;
                    default:
                    opcion="Salir";
                    break;
                }
            }
        }
    }
}
