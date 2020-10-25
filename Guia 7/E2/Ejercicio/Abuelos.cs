namespace Ejercicio
{
    public class Abulos : Adultos
    {
        public override int seAsusta(Niño niño)
        {
            AdultosComunes adultoComun=new AdultosComunes();
            return adultoComun.seAsusta(niño)/2;
        }
    }
}