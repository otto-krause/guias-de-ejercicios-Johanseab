using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
         int num=0;
         int num1=0;
         int num2=0;
         while(num != 6)
         {
            Console.WriteLine("ingrese 1°)fibonacci 2°)Factorial 3°)Mayor 4°)Menor 5°)Cubo 6°)Para salir");
            num = Int32.Parse(Console.ReadLine());
            Matematica Clasenueva = new Matematica(num1,num2);
            switch (num)
            {
               case 1:
               Console.WriteLine("ingrese un numero");
               num1 = Int32.Parse(Console.ReadLine());
               Clasenueva.Fibonacci(num1);
               break;
               case 2:
               Console.WriteLine("ingrese un numero");
               num1 = Int32.Parse(Console.ReadLine());
               Clasenueva.Factorial(num1);
               break;
               case 3:
               Console.WriteLine("ingrese dos numeros");
               num1 = Int32.Parse(Console.ReadLine());
               num2 = Int32.Parse(Console.ReadLine());
               if(Clasenueva.Mayor(num1,num2))
               {
                Console.WriteLine("el primer numero es mayor");
               }
               else
               {
                Console.WriteLine("el segundo numero es mayor");
               }
               break;
               case 4:
               Console.WriteLine("ingrese dos numeros");
               num1 = Int32.Parse(Console.ReadLine());
               num2 = Int32.Parse(Console.ReadLine());
               if(Clasenueva.Menor(num1,num2))
               {
                Console.WriteLine("el primer numero es el menor");
               }
               else
               {
                Console.WriteLine("el segundo numero es el menor");       
               }
               break;
               case 5:
               Console.WriteLine("ingrese un numero");
               num1 = Int32.Parse(Console.ReadLine());
               Clasenueva.Cubo(num1);
               break;
            } 
         }
        }
    }
}
