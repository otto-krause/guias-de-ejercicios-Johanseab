namespace E6
{
    public class Reseña
    {
      int estrellas;
      public int Estrellas { get => estrellas; } 
      string Comentario;

        public Reseña(int estrellas, string comentario)
        {
            this.estrellas = estrellas;
            this.Comentario = comentario;
        }
        
    }
}