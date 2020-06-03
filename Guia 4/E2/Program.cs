using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa= new Empresa();

            int opcion = 0;

            while (opcion<5)
            {
                Console.WriteLine(
                    "[1]Noche de sustos\n"+
                    "[2]Noche de risas\n"+
                    "[3]Generar una lista de Monstruos Respetables\n"+
                    "[4]Energia Generada en la Empresa\n"+
                    "[5]Salir");
                opcion=Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    empresa.NocheDeSustos();
                    break;
                    case 2:
                    empresa.NocheDeRisas();
                    break;
                    case 3:
                    empresa.Respetables();
                    break;
                    case 4:
                    Console.WriteLine("La energia generada en la empresa es: "+empresa.energia());
                    break;   
                }
            }
        }
    }
}
