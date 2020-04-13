using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {
            int num=0;
            Celular celular = new Celular(true,false,40000,3);
            Console.WriteLine("ingrese 1°)Para saber la cantidad de memoria disponible 2°)Para saber si carga sube");
            num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                Console.WriteLine("La cantidad de memoria disponible es:"+celular.MemoriaDisponible());
                break;
                case 2:
                if (celular.TeCargaLaSube())
                {
                Console.WriteLine("Si te carga la sube");
                } 
                else
                {
                Console.WriteLine("No te carga la sube");
                } 
                break;
            }
        }
    }
}