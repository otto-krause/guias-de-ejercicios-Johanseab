using System;

namespace E6
{
    public class Matematica
    {
      int num1;
      int num2;
      int cont=0;
      public Matematica(int num1, int num2)
      {
          this.num1 = num1;
          this.num2 = num2;
      }
      public void Fibonacci(int num1)
      {
          int fibo1= 1, fibo2=2;
          while(cont != num1/2)
          {
           Console.WriteLine(fibo1);
           fibo1 += fibo2;
           Console.WriteLine(fibo2);
           fibo2 += fibo1;
           cont++;
          }
      }
       public void Factorial(int num1)
       {
         int fact=1;
         for (int i = 1; i <= num1 ; i++)
         {
            fact *= i;
         }
         Console.WriteLine("el Factorial es"+fact);
       }
      public bool Mayor(int num1, int num2)
      {
          return num1 > num2;
      }
      public bool Menor(int num1,int num2)
      {
          return num1 < num2;
      }
      public void Cubo(int num1)
      {
          int cubo;
          cubo = num1*num1*num1;
          Console.WriteLine("el cubo del numero es "+cubo);
      }
    }
 }
