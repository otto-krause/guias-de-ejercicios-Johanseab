using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int suma=0,promedio=0;
            int menor=10000000;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero");
                vector[i]= Int32.Parse(Console.ReadLine());
                suma += vector[i];
                promedio= suma/10;
            }    
           for (int i = 0; i < 10; i++)
            {
                    if(vector[i]<menor)
                    {
                        menor=vector[i];
                    }
             }
           for (int i = 0; i < 10 ; i++)
           {
               for (int j = i+1 ; j < 10 ; j++)
               {
                   if(vector[j] > vector[i])
                   {
                       int aux;
                       aux=vector[j];
                       vector[j]=vector[i];
                       vector[i]= aux;
                   }
               }
           }
            Console.WriteLine("la suma es: " +suma);   
            Console.WriteLine("El promedio es de: "+promedio);
            Console.WriteLine("El menor Elemento es: "+menor);
            Console.WriteLine("orden de Mayor a Menor");
            for (int i = 0; i < 10; i++)
            {
               Console.Write(" "+vector[i]); 
            }
        }
    }
}
