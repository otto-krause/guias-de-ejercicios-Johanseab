using System.Collections.Generic;

namespace E6
{ 
    public class juego
    { 
        string tituloDelJuego;
        string GeneroDelJuego;
   
         List<Reseña> Reseñas = new List<Reseña>();

        public string TituloDelJuego { get => tituloDelJuego; }

        public juego(string tituloDelJuego, string generoDelJuego, int estrellas, string comentario)
        {
            this.tituloDelJuego = tituloDelJuego;
            this.GeneroDelJuego = generoDelJuego;
            Reseñas.Add(new Reseña(estrellas, comentario));
        }
        public string Genero()
        {
            return GeneroDelJuego;
        }
        public string Descripcion()
        {
        return "Titulo : "+this.TituloDelJuego+"\nGenero :"+this.GeneroDelJuego;
        }
        public int getEstrellas(List<string> ListadeJuegos)
              {
                  int count=0;
                  foreach (var i in Reseñas)
                  {
                      foreach (var j in ListadeJuegos)
                      {
                          if(this.TituloDelJuego == j) 
                          {
                              count++;
                          }
                      }
                      return i.Estrellas / count++;
                  }
                  return 0;
              }
    }
}