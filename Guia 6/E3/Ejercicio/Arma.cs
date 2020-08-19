namespace Ejercicio
{
    public abstract class Arma
    {
        protected int desgaste;
        protected int potencia;
        protected int cantidadDeUsos;

        protected Arma(int desgaste, int potencia, int cantidadDeUsos)
        {
            this.desgaste = desgaste;
            this.potencia = potencia;
            this.cantidadDeUsos = cantidadDeUsos;
        }

        public abstract int poder();
    }
}