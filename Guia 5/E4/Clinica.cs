using System.Linq;
using System.Collections.Generic;
namespace E4
{
    public class Clinica
    {
      List<Medico> medicos = new List<Medico>();
      string especilidadRequerida;
      public Clinica (string especilidadRequerida)
      {
          Medico n1 = new Medico("Stuwart","Benito","Pediatra",50);
          medicos.Add(n1);
          Medico n2 = new Medico("Nadia","Maldonado","Cardiologo",32);
          medicos.Add(n2);
          Medico n3 = new Medico("Brahian","Sozaki","Cardiologo",30);
          medicos.Add(n3);

          this.especilidadRequerida=especilidadRequerida;
      }
      public string DisponibilidadDelMedico()
      {
          List<Medico> aux = medicos.Where(medico => especilidadRequerida == medico.Especialidad).ToList();
          List<Medico> medicosDisponibles = aux.Where(medico => medico.EstaDisponible()).ToList();
          int cont = medicosDisponibles.Count;
          switch (cont)
          {
              case 0:
              return "Intentelo otra vez mas tarde";
              default:
               Medico disponible = medicosDisponibles.First();
               disponible.AumentoTurnos();
               return "El nombre del medico/a que lo atendera es: "+disponible.Nombre+" "+disponible.Apellido;
          }
      }
    }
}