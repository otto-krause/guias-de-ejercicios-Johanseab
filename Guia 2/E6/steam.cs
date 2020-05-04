using System.Collections.Generic;

namespace E6
{
    public class steam
    {
        List<juego> ListadeJuegos = new List<juego>();
        public steam()
        {
            juego Minecraft = new juego("Minecraft","surpervivencia",5,"esta bueno");
            ListadeJuegos.Add(Minecraft);
            juego Minecraft2=new juego("Minecraft","Supervivencia",5,"BUENARDOOOOOOOOOO");
            ListadeJuegos.Add(Minecraft2);
            juego Terraria = new juego("Terraria","Supervivencia",3,"copia de minecraft en 2d");
            ListadeJuegos.Add(Terraria);
            juego CSGO = new juego("CSGO: Counter Stike Global Offensive","shoter",2,"mucho hackers");
            ListadeJuegos.Add(CSGO);
        }
        public List<string> PorGenero(string GeneroDelJuego)
        {
            List<string> JuegoPorGenero = new List<string>();
            foreach(var Buscar in ListadeJuegos)
            {
                if(Buscar.Genero()== GeneroDelJuego)
                {
                    JuegoPorGenero.Add(Buscar.Descripcion());
                }
            }
            return JuegoPorGenero;
        }
        
        public List<string> PorCalificacion(string Calificacion)
        {
            List<string> titulos = new List<string>();
            List<string> porCalificacion = new List<string>();
            foreach (var i in ListadeJuegos)
            {
                titulos.Add(i.TituloDelJuego);
            }
            foreach (var i in ListadeJuegos)
            {
                switch(Calificacion)
                {
                    case "Alta":
                    if(i.getEstrellas(titulos)>=4)
                    {
                        porCalificacion.Add(i.Descripcion());
                    }
                    break;
                    case "Media":
                    if(i.getEstrellas(titulos) == 3)
                    {
                        porCalificacion.Add(i.Descripcion());
                    }
                    break;
                    case "Baja":
                    if(i.getEstrellas(titulos)<= 2)
                    {
                       porCalificacion.Add(i.Descripcion());
                    }
                    break;
                }
            }
            return porCalificacion;
        }
        
    }
}