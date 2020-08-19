namespace Ejercicio
{
    public class Blasters : Arma
    {
        public Blasters(int desgaste, int potencia, int cantidadDeUsos) : base (desgaste,potencia,cantidadDeUsos)
        {
        }
        public override int poder()
        {
            if(potencia > cantidadDeUsos) return potencia-cantidadDeUsos;
            else return 1;
        }
    }
}