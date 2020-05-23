using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int frecuencia;
            int precio;
            MotherBoard mother = new MotherBoard(3000);

            List<Componentes> componentes = new List<Componentes>();
            
            Console.WriteLine("ingrese la frecuencia y precio del disco SSD");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio= Int32.Parse(Console.ReadLine());
            DiscoSSD ssd= new DiscoSSD(frecuencia, precio);  

            Console.WriteLine("ingrese la frecuencia y precio del disco HDD");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio= Int32.Parse(Console.ReadLine());
            DiscoHDD hdd= new DiscoHDD(frecuencia, precio);

            Console.WriteLine("ingrese la frecuencia y precio de la placa de video");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio= Int32.Parse(Console.ReadLine());
            PlacaDeVideo placadevideo= new PlacaDeVideo(frecuencia, precio);

            Console.WriteLine("ingrese la frecuencia y precio de la lestora CD");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio= Int32.Parse(Console.ReadLine());
            LectoraCD lectoracd= new LectoraCD(frecuencia, precio); 

            Console.WriteLine("ingrese la frecuencia y precio de la ram");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio= Int32.Parse(Console.ReadLine());
            MemoriaRam ram= new MemoriaRam(frecuencia, precio);

            componentes.Add(ssd);
            componentes.Add(hdd);
            componentes.Add(placadevideo);
            componentes.Add(lectoracd);
            componentes.Add(ram);

            PC pc= new PC(mother,componentes);

            Console.WriteLine("El precio total de la pc es: "+pc.PrecioTotal());
            Console.WriteLine("Se puede armar la pc?\n"+pc.SePuedeArmar());
        }
    }
}
