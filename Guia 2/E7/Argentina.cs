using System.Collections.Generic;
namespace E7
{
    public class Argentina
    {
        List<Alfajor> alfajor=new List<Alfajor>();
        public Argentina()
        {
            Alfajor alfajor1=new Alfajor("Triple fruta",100,"Waymayen");
            Alfajor alfajor2=new Alfajor("Dulce de Leche",50,"Jorgito");
            Alfajor alfajor3=new Alfajor("Triple de chocolate",38,"Capitan del Espacio");
            alfajor.Add(alfajor1);
            alfajor.Add(alfajor2);
            alfajor.Add(alfajor3);
        }
       public void BajarElPrecioDelPetroleo()
        {
            foreach (var i in alfajor)
            {
              i.Aumentos(1);  
            }
        }
        public void MillaiHablaPorTV()
        {
            foreach (var i in alfajor)
            {
               i.Aumentos(2); 
            }
        }
        public void CoronaVairas()
        {
            foreach (var i in alfajor)
            {
                i.Aumentos(3);
            }
        }
        public int inflacion()
        {
            int suma=0;
            foreach (var i in alfajor)
            {
                suma+=i.Precio;
            }
            return suma;
        }

    }
}