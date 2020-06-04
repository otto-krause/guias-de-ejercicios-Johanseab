using System.Collections.Generic;
namespace E5
{
    public abstract class SerPensante
    {
        protected int inteligencia;
        protected List<string> conocimiento;
        protected List<string> intereses;

        protected SerPensante(int inteligencia)
        {
            this.inteligencia=inteligencia;
            conocimiento=new List<string>();
            intereses = new List<string>();
        }
        public abstract void pensar(string tema);
        public abstract void estudiar(string conocimientoNuevo);
    }
}