namespace Ejercicio
{
    public class Carpe : Varita
    {
        public Carpe(int potencia, Receta receta) : base(potencia, receta)
        {
        }

        public override int tiempoDeLaReceta()
        {
            return receta.Pasos/potencia;
        }
    }
}