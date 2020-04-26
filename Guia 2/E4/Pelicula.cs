namespace E4
{
    public class Pelicula
    {
        string Nombre;
        string Genero;
        int Año;
        string Director;
        public Pelicula(string Nombre,string Genero,int Año,string Director)
        {
            this.Nombre = Nombre;
            this.Genero = Genero;
            this.Año = Año;
            this.Director = Director;
        }
        public string Generos()
        {
            return Genero;
        }
        public string Nombres()
        {
            return Nombre;
        }
        public int Años()
        {
            return Año;
        }
        public string Directores()
        {
            return Director;
        }
        public string Descripcion()
        {
          return "Titulo: "+this.Nombre+"\nGenero: "+this.Genero+"\nAño: "+this.Año+"\nDirector: "+this.Director;
        }
    }
}