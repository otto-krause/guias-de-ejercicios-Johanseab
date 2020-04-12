using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
           int ladoA=0,ladoB=0,hipotenusa=0,num=0;
           while(num != 5)
           {
           Console.WriteLine("ingrese lado A");
           ladoA = Int32.Parse(Console.ReadLine());
           Console.WriteLine("ingrese lado B");
           ladoB = Int32.Parse(Console.ReadLine());
           Console.WriteLine("ingrese hipotenusa");
           hipotenusa = Int32.Parse(Console.ReadLine());
           triangulo Triangulo = new triangulo(ladoA,ladoB,hipotenusa);
           Console.WriteLine("ingrese para saber si 1°)Es escaleno 2°)Es Isoceles 3°)Es equilatero 4°)Es triangulo Rectangulo 5°)para salir");
           num = Int32.Parse(Console.ReadLine());
           switch (num)
           {
               case 1:
               Console.WriteLine("El triangulo es escaleno? "+Triangulo.EsEscaleno());
               break;
               case 2:
               Console.WriteLine("El tirangulo es Isoceles? "+Triangulo.EsIsoceles());
               break;
               case 3:
               Console.WriteLine("El triangulo es Equilatero?"+Triangulo.EsEquilatero());
               break;
               case 4:
               Console.WriteLine("Es Triangulo Rectangulo?"+Triangulo.EsTrianguloRectagulo());
               break;
           }
         }
        }
    }
}






