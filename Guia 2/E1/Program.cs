using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {     
             int num = 1;
             List <int> numeros =new List<int>();
             while(num != 0)
             { 
              Console.WriteLine("ingrese el numero que desea o 0 para terminar el ingreso: ");
              num = Int32.Parse(Console.ReadLine()); 
              if(num!=0)
              {
               numeros.Add(num);
              }
             }
          foreach (int Todos in numeros)
          {
           Console.WriteLine("el numero ingresado es: "+Todos);
          }
          Console.WriteLine("la cantidad de nuemeros ingresados es: "+numeros.Count);
          Console.WriteLine("el primer numero ingresado es: "+numeros[0]);
          Console.WriteLine("El ultimo numero ingresado es: "+numeros[numeros.Count-1]);
          foreach (int Mayor in numeros)
          {
             if(Mayor>50)
             {
                 Console.WriteLine("Los numeros mayores de 50 son :"+Mayor);
             }
          }
        }
    }
}
