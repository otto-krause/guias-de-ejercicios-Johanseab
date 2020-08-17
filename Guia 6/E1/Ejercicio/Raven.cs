using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Raven : Titan
    {
     List<string> pensamiento;
     int cantidadDePorciones;
     int felicidad;
     public Raven(int tristeza) : base(tristeza)

     {
         this.pensamiento=new List<string>();
         pensamiento.Add("donde estara mi Papi");
         pensamiento.Add("se perdio el perrito");
         pensamiento.Add("voy contigo Pipo");
         pensamiento.Add("porque se fue Robocop");
         pensamiento.Add("se termino la MANTECA");
         cantidadDePorciones=4;
         felicidad=tristeza;
     } 
     public override void comerPizza()=>felicidad+=2*cantidadDePorciones;
     public override void llorandoPorRobocop()=>pensamiento.RemoveAt(0);
     public override bool estarTriste()
     {
         int count = 0;
         foreach (var i in pensamiento)
         {
             if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") 
             || i.Contains("Pipo") || i.Contains("MANTECA"))count++;
         }
         return count>=5&&felicidad>=10;
     }
      public override int poder()
      {
          int count=0;
          foreach (var i in pensamiento)
          {
            if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") 
            || i.Contains("Pipo") || i.Contains("MANTECA"))count++; 
          }
          return count;
      } 
    }
}