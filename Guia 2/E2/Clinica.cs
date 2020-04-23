
using System.Collections.Generic;

namespace E2
{
    public class Clinica
    {
      List<Medico> Medicos = new List <Medico>();
      public Clinica()
      {
        Medico Brahian = new Medico("Brahian","Sozaki","Ginecologo",40);
        Medicos.Add(Brahian);
        Medico Rodrigo = new Medico("Rodrigo","Gardeazabal","Pediatra",50);
        Medicos.Add(Rodrigo);
        Medico Venialgo = new Medico("Sebastian","Venialgo","Ginecobstetra",60);
      }
      public string Informacion(string espec)
      {
        foreach ( var Buscar in Medicos)
        {
            if (espec == Buscar.Especializado())
            {
              if (Buscar.EstaDisponible())
              {
                return Buscar.Descripcion();
              }
            }
        }
        return "intentelo de nuevo mas tarde";
      }
    }
}