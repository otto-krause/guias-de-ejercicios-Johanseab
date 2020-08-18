namespace Ejercicio
{
    public class Acebo : Varita
    {
      public Acebo(int potencia, Receta receta) : base(potencia, receta)
      {
      }
      public override int tiempoDeLaReceta()
      {
          return receta.Ingredientes()+potencia;
      }
    }
}