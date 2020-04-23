namespace E2
{
    public class Medico
    {
        string Nombre;
        string Apellido;
        string Especialidad; 
        int CantDeTurnos;

        public Medico(string Nombre,string Apellido,string Especialidad,int CantDeTurnos)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Especialidad = Especialidad;
            this.CantDeTurnos = CantDeTurnos;
        }
        public bool EstaDisponible()
        {
            return CantDeTurnos<50;
        }
        public string Especializado()
        {
            return Especialidad;
        }
        public string Descripcion()
        {
            return "El nombre del medico es: "+this.Nombre+"\n El apellido es : "+this.Apellido;
        }
    }
}