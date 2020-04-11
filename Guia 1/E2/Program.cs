using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0,num2=0,Producto=0,resto=0,cociente=0;
            Console.WriteLine("inserte dos numeros");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            for (int i = 0; i < num2; i++)
            {
                Producto=Producto+num1;
            }
           if (num1 > 0 && num2 > 0)
           {
               cociente = 0;
               resto = num1;
               while (resto >= num2)
               {
                   resto -= num2;
                   cociente++;
               }
           }
          Console.WriteLine("el producto es: "+Producto);
          Console.WriteLine("el cociente es: "+cociente);
          Console.WriteLine("el resto es: "+resto);
        }
    }
}
