using System;
using System.Collections.Generic;
using System.Linq;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Persona> personas=new List<Persona>();
           Persona p1 = new Persona(30,"Juan","Perez");
           Persona p2 = new Persona(15,"Juan","Rodrigez");
           Persona p3 = new Persona(57,"Jose","Perez");
           personas.Add(p1);
           personas.Add(p2);
           personas.Add(p3);

           List<Persona>mayoresDeEdad=personas.Where(persona => persona.Edad >= 18).ToList();
           Console.WriteLine("Mayores de Edad:\n");
           mayoresDeEdad.ForEach(personas => Console.WriteLine("Nombre: " + personas.Nombre + "\nApellido: " + personas.Apelliodo + "\nEdad: " + personas.Edad));

           List<Persona> Juanes=personas.Where(persona => persona.Nombre == "Juan").ToList();
           Console.WriteLine("\nLas personas llamadas Juan:\n");
           Juanes.ForEach(personas => Console.WriteLine("Nombre: " + personas.Nombre + "\nApellido: " + personas.Apelliodo + "\nEdad: " + personas.Edad));

           List<Persona> Perez=personas.Where(personas => personas.Apelliodo == "Perez").ToList();
           Console.WriteLine("\nLas personas con apellido Perez: \n");
           Perez.ForEach(persona => Console.WriteLine("Nombre: " + persona.Nombre + "\nApellido: " + persona.Apelliodo + "\nEdad: " + persona.Edad));
        }
    }
}
