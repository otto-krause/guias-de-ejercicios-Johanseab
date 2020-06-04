namespace E5
{
    public class Humano : SerPensante
    {
      public Humano(int inteligencia) : base(inteligencia)
      {
      }
      public override void pensar(string tema) 
      {
          for(int i= conocimiento.Count; i== conocimiento.Count-5;i--)
          {
              if(conocimiento[i]==tema)inteligencia+=5;
          }
      } 
      public override void estudiar(string conocimientoNuevo)
      {
          conocimiento.Add(conocimientoNuevo);
          foreach (var i in intereses)
          {
              if(conocimientoNuevo==i)inteligencia++;
          }
      }
    }
}