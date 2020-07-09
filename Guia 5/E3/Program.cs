using System;
using System.Collections.Generic;
using System.Linq;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Caballero_Del_Zodiaco> caballeros = new List<Caballero_Del_Zodiaco>();

          Armadura armaduraDeSeiya = new Armadura("Cloth de Pegaso","Bronce");
          Caballero_Del_Zodiaco Seiya=new Caballero_Del_Zodiaco("Seiya","Atena", armaduraDeSeiya,"Sagitario");
          caballeros.Add(Seiya);

          Armadura armaduraDeHyoga = new Armadura("Cygnus cloth","Bronce");
          Caballero_Del_Zodiaco Hyoga=new Caballero_Del_Zodiaco("Hyoga","Atena",armaduraDeHyoga,"Acuario");
          caballeros.Add(Hyoga);

          Armadura armaduraDeDeathMask = new Armadura("Cloth de Cancer","Oro");
          Caballero_Del_Zodiaco DeathMask=new Caballero_Del_Zodiaco("DeathMask","Atena",armaduraDeDeathMask,"Cancer");
          caballeros.Add(DeathMask);

          Armadura armaduraDeCube = new Armadura("Surplice de Dullahan","Bronce");
          Caballero_Del_Zodiaco Cube = new Caballero_Del_Zodiaco("Cube","Hades",armaduraDeCube,"Dullahan");
          caballeros.Add(Cube);

          Console.WriteLine("Armadura de los caballeros que apoyan a Atena: ");
           
          List<Caballero_Del_Zodiaco> armadurasDeSeguidoresDeAtena=caballeros.Where(caballeros => caballeros.DiosAlQueApoya == "Atena").ToList();
          armadurasDeSeguidoresDeAtena.ForEach(armaduras => Console.WriteLine(armaduras.getArmadura()));

          Console.WriteLine("\nDioses: \n");

          List<string> Dioses=new List<string>();
          caballeros.ForEach(i=>Dioses.Add(i.DiosAlQueApoya));

          var DioseSinRepetir = Dioses.Distinct();

          foreach (var i in DioseSinRepetir) 
          {
             Console.WriteLine(i); 
          }

          List<string> Signo=new List<string>();
          caballeros.ForEach(i=>Signo.Add(i.SignoDelZodiaco));

          List<string> SignosDelZodiacoConC=new List<string>();
          foreach (var i in Signo)
          {
              if(i.StartsWith("C"))
              {
                  SignosDelZodiacoConC.Add(i);
              }
          }
          SignosDelZodiacoConC.ForEach(i=>Console.WriteLine("Signos del zodiaco que comienzan con 'C': "+i));
        }
    }
}
