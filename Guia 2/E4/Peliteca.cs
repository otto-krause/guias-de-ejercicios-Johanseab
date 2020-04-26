using System.Collections.Generic;

namespace E4
{
    public class Peliteca
    {
        List<Pelicula> Peliculas= new List<Pelicula>();
        public Peliteca()
        {
         Pelicula Spirit = new Pelicula("Spirit:el corcel indomable","Familiar",2002,"Kelly Absury");
         Peliculas.Add(Spirit);
         Pelicula Tumba = new Pelicula("La tumba de las luciernagas","Belico",1988,"Isao Takahata");
         Peliculas.Add(Tumba);
         Pelicula IT = new Pelicula("IT:capitulo dos","Sobrenatural",2019,"Andres Muschietti");
         Peliculas.Add(IT);
         Pelicula Ring = new Pelicula("The Ring","Sobrenatural",2002,"Gore Verbinski");
         Peliculas.Add(Ring);
        }
      public List<string> PorGenero(string Genero)
      {
          List<string> PelisPorGenero = new List<string>();
          foreach (var Buscar in Peliculas)
          {
           if(Buscar.Generos() == Genero)   
           {
             PelisPorGenero.Add(Buscar.Descripcion());
           }
          }
          return PelisPorGenero;
      }
      public List<string> PorNombre(string Nombre)
      {
          List<string> PelisPorNombre = new List<string>();
          foreach (var Buscar in Peliculas)
          {
              if(Buscar.Nombres()== Nombre)
              {
                  PelisPorNombre.Add(Buscar.Descripcion());
              }
          }
          return PelisPorNombre;
      }
     public List<string> PorAño(int Año)
     {
         List<string> PelisPorAño =new List<string>();
         foreach (var Buscar in Peliculas)
         {
          if(Buscar.Años()== Año)
          {
              PelisPorAño.Add(Buscar.Descripcion());
          }  
         }
        return PelisPorAño;
     }
     public List<string> PorDirector(string Director)
     {
         List<string> PelisPorDirector = new List<string>();
         foreach (var Buscar in Peliculas)
         {
            if(Buscar.Directores()== Director)
            {
                PelisPorDirector.Add(Buscar.Descripcion());
            }
         }
         return PelisPorDirector;
     }
     public string TotalDePeliculas()
     {
         return "Las peliculas que hay son: "+Peliculas.Count;
     }
     public string ContarPeliculas(string Genero)
     {
       int count=0,count2=0,count3=0;
       foreach (var Buscar in Peliculas)
       {
           if(Buscar.Generos() == "Sobrenatural")
           {
               count++;
           }
           else
           {
               if(Buscar.Generos() == "Familiar")
               {
                   count2++;
               }
               else
               {
                   if(Buscar.Generos() == "Belico")
                   {
                       count3++;
                   }
               }
           }
       }
       if(Genero == "Sobrenatural")
       {
           return "Peliculas de Genero Sobrenatural: "+count;
       }
       else
       {
           if(Genero == "Familiar")
           {
               return "Peliculas de Genero Familiar: "+count2;
           }
           else
           {
               if(Genero == "Belico")
               {
                   return "Peliculas de Genero Belico: "+count3;
               }
           }
       }
       return "No hay ninguna pelicula que pertenezca a ese genero";
     }
    }
}