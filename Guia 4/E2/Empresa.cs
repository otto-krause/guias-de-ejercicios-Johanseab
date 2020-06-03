using System.Collections.Generic;
namespace E2
{
    public class Empresa
    {
        List<Monstruos> amigable= new List<Monstruos>();
        List<Monstruos> peligrosos= new List<Monstruos>();
        List<Monstruos> respetables= new List<Monstruos>();

        public Empresa()
        {
            amigable.Add(new Amigable(10));
            amigable.Add(new Amigable(80));

            peligrosos.Add(new Amigable(19));
            peligrosos.Add(new Amigable(73));
        }
        public void NocheDeSustos()
        {
            foreach(var i in peligrosos) i.asustar();
            foreach(var i in amigable) i.asustar();
        }
        public void NocheDeRisas()
        {
            foreach(var i in peligrosos) i.reir();
            foreach(var i in amigable) i.reir();
        }
        public void Respetables()
        {
          foreach(var i in amigable)
          {
              if(i.Respeto>70) respetables.Add(i);
          }
          foreach(var i in peligrosos)
          {
              if(i.Respeto>70)respetables.Add(i);
          }
        }
        public int energia()
        {
            int suma =0;
            foreach (var i in amigable)
            {
                suma += i.Respeto;
            }
            foreach (var i in peligrosos)
            {
                suma += i.Respeto;
            }
            return suma;
        }
    }
}