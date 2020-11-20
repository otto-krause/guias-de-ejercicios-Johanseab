using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comandos cordenadas= new Comandos();
            double longitud=0;
            double latitud=0;

            Console.WriteLine("ingrese longitud y latitud");
            longitud=Convert.ToDouble(Console.ReadLine());
            latitud=Convert.ToDouble(Console.ReadLine());

            cordenadas.cargarJSON();
            Console.WriteLine(cordenadas.Buscar(longitud,latitud));
            Console.WriteLine(cordenadas.BuscarTrabajo(longitud,latitud));
        }
    }
}
