using System.Collections.Generic;
namespace E2
{
    public class Constructora
    {
       int presupuesto;
       int horasaTrabajarParaTerminar;
       List<Contratistas> contrtistas = new List<Contratistas>();

       public Constructora(int presupuesto, int  horasaTrabajarParaTerminar, List<Contratistas> contrtistas) 
       {
           this.presupuesto=presupuesto;
           this.horasaTrabajarParaTerminar=horasaTrabajarParaTerminar;
           this.contrtistas=contrtistas;
       }
       public bool ElPresupuestoAlcanza()
       {
           int presupuestoNecesario=0;
           foreach (var i in contrtistas)
           {
               i.trabajar(horasaTrabajarParaTerminar);
               presupuestoNecesario+=i.cobrar();
           }
           return presupuesto>presupuestoNecesario;
       }
    }
}