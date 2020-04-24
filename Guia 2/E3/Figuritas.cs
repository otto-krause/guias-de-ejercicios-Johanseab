namespace E3
{
    public class Figuritas
    {
        string NombreJugador;
        string Posicion;
        string PaisDelJugador;
        int NumDeFigurita;
        
        public Figuritas(string NombreJugador,string Posicion,string PaisDelJugador,int NumDeFigurita)
        {
           this.NombreJugador = NombreJugador;
           this.Posicion = Posicion;
           this.PaisDelJugador = PaisDelJugador;
           this.NumDeFigurita = NumDeFigurita;
        }
        public string Posiciones()
        {
            return Posicion;
        }
        public int Numero()
        {
            return NumDeFigurita;
        }
    }
}