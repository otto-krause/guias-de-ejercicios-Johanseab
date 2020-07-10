using System;
using System.Collections.Generic;
using System.Linq;
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
          List<int> numeros = new List<int>(); 
          Console.WriteLine("Ingrese los numeros que desee,seguido de 0 para finalizar los ingresos");
          int ingresa = 0;
          int seguir = 1;
          while (seguir != 0)
          {
              ingresa = Int32.Parse(Console.ReadLine());
              switch (ingresa)
              {
                  case 0:
                  seguir=0;
                  break;
                  default:
                  numeros.Add(ingresa);
                  break;
              }
          }
          Console.WriteLine("Los numeros ingresados son: ");
          numeros.ForEach(i=>Console.WriteLine(i));
          
          Console.WriteLine("\nLa cantidad de impares es: ");
          Console.WriteLine(numeros.Count( x => x % 2 != 0));

          Console.WriteLine("\nLos numeros mayores de 50 son: ");
          numeros.Where(x => x > 50).ToList().ForEach(i=>Console.WriteLine(i));

          Console.WriteLine("\nLa cantidad total es de: ");
          Console.WriteLine(numeros.Count(x => x >50)+" numeros mayores a 50");
        }
    }
}
