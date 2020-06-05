namespace E3
{
    public class Juego
    {
        private string nombre;
        private int añoDeLanzamiento;
        private string nombreDeLaConsola;
        public int AñoDeLanzamiento {get => añoDeLanzamiento;}
        public string NombreDeLaConsola{ get=> nombreDeLaConsola;}
        public string Nombre{get=>nombre;}
        public Juego(string nombre,int añoDeLanzamiento,string nombreDeLaConsola)
        {
            this.nombre=nombre;
            this.añoDeLanzamiento=añoDeLanzamiento;
            this.nombreDeLaConsola=nombreDeLaConsola;
        }
    }
}