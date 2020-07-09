using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
          string especialidadDeseada;
          Console.WriteLine("Ingrese la espcialidad del medico del cual quiere sacar turno(Pediatra o Cardiologo)"); 
          
          especialidadDeseada = Console.ReadLine(); 

          Clinica pedido = new Clinica(especialidadDeseada);

          Console.WriteLine(pedido.DisponibilidadDelMedico()); 
        }
    }
}
