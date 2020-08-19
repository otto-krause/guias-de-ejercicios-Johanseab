namespace Ejercicio
{
    public class Sables : Arma
    {
        public Sables(int desgaste, int potencia, int cantidadDeUsos) : base(desgaste, potencia, cantidadDeUsos)
        {
        }
        public override int poder()
        {
            return potencia*cantidadDeUsos*2;
        }
    }
}