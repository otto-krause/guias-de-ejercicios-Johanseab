using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    public class RicardoTapia : Titan
    {
        List<Arma> arsenal;
        int cantidadDePorciones;
        public RicardoTapia(List<Arma> arsenal, int tristeza) : base(tristeza)
        {
            this.cantidadDePorciones=10;
            this.arsenal=arsenal;
        }
        public override void comerPizza()=>tristeza-=1*cantidadDePorciones;
        public override void llorandoPorRobocop()=>tristeza+=6;
        public override bool estarTriste()
        {
            return arsenal.Max(arma=>arma.Fuerza())<100&&tristeza>25;
        }
        public override int poder()
        {
            return arsenal.Max(arma=>arma.Fuerza())-tristeza;
        }
    }
}