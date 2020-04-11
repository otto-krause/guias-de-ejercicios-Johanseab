using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            Console.WriteLine("ingrese un numero");
            num=Int32.Parse(Console.ReadLine());
            NumeroPar(num);
            if(NumeroPrimo(num))
            {
                Console.WriteLine("el numero es primo");
            }
            else
            {
                Console.WriteLine("el numero no es primo");
            }
        }
        static  void NumeroPar(int num)
        {
            if (num % 2== 0)
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("el numero no es par");
            }
        }
        static bool NumeroPrimo(int num)
        {
          int divisor=2,resto=0;
          while (divisor < num)
          {
              resto = num % divisor;
              if(resto == 0)
              {
                return false;
              }
              divisor = divisor + 1;
          }
            return true;
        }
    }
}
