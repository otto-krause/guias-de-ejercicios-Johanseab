namespace E1
{
    public class Planta
    {
        private int BarrasDeUranio;
        MrBurns Burns;        
        private Empleado empleado;

        public Planta(int BarrasDeUranio, MrBurns Burns, Empleado empleado)
        {
            this.BarrasDeUranio = BarrasDeUranio;
            this.Burns = Burns;
            this.empleado = empleado;
        }

        public bool EstaEnPeligro()
        {
            return (BarrasDeUranio > 10000 && empleado.estaDistraido())
                   || !Burns.esMillonario();
        }

        public void CambiarEmpleado(Empleado nuevoempleado)
        {
         empleado = nuevoempleado;
        }
    }
}