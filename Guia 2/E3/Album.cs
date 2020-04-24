using System.Collections.Generic;
namespace E3
{
    public class Album
    {
        List<Figuritas> Figurita = new List<Figuritas>();
        public Album()
        {
          Figuritas Messi = new Figuritas("Messi","Delantero","Argentina",10);
          Figurita.Add(Messi);
          Figuritas Cristiano = new Figuritas("Cristiano","Delantero","Portugal",14);
          Figurita.Add(Cristiano);
          Figuritas Maradona = new Figuritas("Maradona","Delantero","Argentina",50);
          Figurita.Add(Maradona);
        }
        public string NuevaFigurita(string NombreJugador,string Posicion,string PaisDelJugador,int NumDeFigurita)
       { 
         foreach (var comparacion in Figurita)
         {
             if(NumDeFigurita == comparacion.Numero())
             {
              return"la figurita ya se encuentra en el album";
             }
         }
         Figuritas Nueva = new Figuritas(NombreJugador,Posicion,PaisDelJugador,NumDeFigurita);
         Figurita.Add(Nueva);
         return "la figurita fue agregada al album";
       }
       public string CuantosDelanteros()
       {
         int Count=0;
         foreach (var Buscar in Figurita)
         {
             if(Buscar.Posiciones() == "Delantero")
             {
                Count++;
             }
         }
         if (Count != 0)
             {
               return "la cantidad de delanteros es: "+Count;
             } 
         return "no hay delanteros en el album";
       }
       public string CuantosMediocampostas()
       {
         int Count=0;
         foreach (var Buscar in Figurita)
         {
             if(Buscar.Posiciones()== "MediCampista")
             {
               Count++;
             }
         }
         if(Count !=0 )
         {
           return "La cantidad de Mediocampistas es: "+Count;
         }
         return "no hay Medio campistas en el album";
       }
       public bool EstaCompleto()
       {
         return Figurita.Count == 352;
       }
    }
}