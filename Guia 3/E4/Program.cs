using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tragalibros Jonny = new Tragalibros();
            Tragalibros Jimmy = new Tragalibros();
            Tragalibros Mendoza = new Tragalibros();

            string opcion = "";
            string titulo;
            string autor;
            string nombre;

            while (opcion != "Salir")
            {
                Console.WriteLine(
                "1)Ingrese lectura nueva\n"+
                "2)CI de Jonny leyo\n"+
                "3)CI de Jimmy leyo\n"+
                "4)CI de Mendoza leyo");
                 opcion=Console.ReadLine();

                 switch (opcion)
                 {
                     case "1":
                     Console.WriteLine("ingrse el titulo, el autor del libro y quiel lo leyo");
                     titulo = Console.ReadLine();
                     autor = Console.ReadLine();
                     nombre = Console.ReadLine(); 
                     Libro libro = new Libro(titulo, autor);
                     switch (nombre)
                     {
                         case "Jonny":
                         Jonny.Leer(libro);
                         break;
                         case "Jimmy":
                         Jonny.Leer(libro);
                         break;
                         case "Mendoza":
                         Mendoza.Leer(libro);
                         break;
                    }
                    break; 

                    case "2":
                    Console.WriteLine("El CI de Jonny es: "+Jonny.CalcularCI());
                    break;
                    case "3":
                    Console.WriteLine("El CI de Jimmy es: "+Jimmy.CalcularCI());
                    break;
                    case "4":
                    Console.WriteLine("El CI de Mendoza es: "+Mendoza.CalcularCI());
                    break;
                    default: 
                    opcion="Salir";
                    break;
                 }
            }
        }
    }
}
