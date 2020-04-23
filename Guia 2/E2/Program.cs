using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string espec;
            Console.WriteLine("ingrese la Especialidad del medico que esta buscando ");
            espec= Console.ReadLine(); 
            Clinica clinica= new Clinica();
            Console.WriteLine("mensaje del sistema: "+ clinica.Informacion(espec));
        }
    }
}
