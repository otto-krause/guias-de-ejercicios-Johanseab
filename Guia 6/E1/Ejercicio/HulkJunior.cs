namespace Ejercicio
{
    public class HulkJunior : Titan
    {
        string color;
        public HulkJunior(int tristeza) : base(tristeza)
        {
            this.color="Verde";
        }
        public int NivelDeTristeza()
        {
            return tristeza;
        }
        public void cambiarDeColor(string color)
        {
            this.color=color;
            tristeza+=4;
        }
        public override void comerPizza()=>color="Amarillo patito fluorecente de las montañas de himalaya amazonico";
        public override void llorandoPorRobocop()
        {
            if(tristeza>7)tristeza-=8;
            else tristeza -= tristeza;
        }
        public override bool estarTriste()
        {
         return tristeza>5;
        }
        public override int poder()
        {
            return color.Length*13;
        }
    }
}