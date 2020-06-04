namespace E5
{
    public class Cyborg : SerPensante
    {
      public Cyborg(int inteligencia) : base(inteligencia)
      {
      }
      public override void pensar(string tema)
      {
          inteligencia+=conocimiento.Count;
      }
      public override void estudiar(string conocimientoNuevo)
      {
          conocimiento.Add(conocimientoNuevo);
          foreach (var i in intereses)
          {
              if(conocimientoNuevo==i) inteligencia++;
          }
      }
    }
}