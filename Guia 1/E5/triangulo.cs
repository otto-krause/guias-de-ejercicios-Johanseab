namespace E5
{
    public class triangulo
    {
      int ladoA;
      int ladoB;
      int hipotenusa;
      public triangulo(int ladoA, int ladoB, int hipotenusa)
      {
          this.ladoA = ladoA;
          this.ladoB = ladoB;
          this.hipotenusa = hipotenusa;
      }
      public bool EsEscaleno()
    {
        return ladoA != ladoB && ladoA != hipotenusa && hipotenusa != ladoB; 
    }
    public bool EsIsoceles()
    {
        return ladoA == ladoB && ladoA == hipotenusa && ladoB == hipotenusa;
    }
    public bool EsEquilatero()
    {
        return ladoA == ladoB && ladoB == hipotenusa;
    }
    public bool EsTrianguloRectagulo()
    {
        return hipotenusa*hipotenusa == ladoA*ladoA + ladoB*ladoB;
    }
    }
}