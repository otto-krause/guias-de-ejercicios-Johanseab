namespace Ejercicio
{
    public abstract class Titan
    {
        protected int tristeza;
        public Titan (int tristeza)
        {
            this.tristeza=tristeza;
        }
        public abstract void comerPizza();
        public abstract bool estarTriste();
        public abstract void llorandoPorRobocop();
        public abstract int poder();
    }
}