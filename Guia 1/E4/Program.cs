using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos=0;
            int num=0;
            Gatito Robin = new Gatito("Robin",true,30);
            while (num != 6)
            {
            Console.WriteLine("1°)Nombre: 2°)Vacunas: 3°)jugar: 4°)Comer: 5°)Salud: 6)Para salir ");
            Console.WriteLine("selecciones una opcion por favor: ");
            num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                Console.WriteLine("El gatito se llama: "+Robin.Nombre());
                break;
                case 2:
                Console.WriteLine("El gato esta saludable? "+Robin.EstaVacunado());
                break;
                case 3:
                Console.WriteLine("ingrese cuantos minutos juego el gato: ");
                minutos = Int32.Parse(Console.ReadLine()); 
                break;
                case 4:
                Console.WriteLine("El gato comio ");
                Robin.Comer();
                break;
                case 5:
                Console.WriteLine("El gato esta saludable? :"+Robin.EstaSaludable());
                break;
            }
         }
        }
    }
}
