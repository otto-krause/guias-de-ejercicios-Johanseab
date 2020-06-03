namespace E2
{
    public class Amigable : Monstruos
    {
        public Amigable(int respeto):base(respeto)
        {
        }
        public override void asustar()=>respeto+=7;
        public override void reir()=>respeto-=1;
    }
}