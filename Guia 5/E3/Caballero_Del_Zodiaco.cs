using System.Collections.Generic;
namespace E3
{
    public class Caballero_Del_Zodiaco
    {
      private string nombre;
      private string diosAlQueApoya;
      public string DiosAlQueApoya { get => diosAlQueApoya; }
      private Armadura armadura;
      private string signoDelZodiaco;
      public string SignoDelZodiaco { get => signoDelZodiaco; }

      public Caballero_Del_Zodiaco(string nombre,string diosAlQueApoya,Armadura armadura,string signoDelZodiaco)  
      {
          this.nombre=nombre;
          this.diosAlQueApoya=diosAlQueApoya;
          this.armadura=armadura;
          this.signoDelZodiaco=signoDelZodiaco;
      }
      public string getArmadura()
      {
          return "Nombre de la armadura: "+armadura.Nombre+"\nMaterial de la armadura: "+armadura.Material;
      }
    }
}