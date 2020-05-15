using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
          Homero homero = new Homero(2);
          Lenny lenny = new Lenny();
          PatoBalancin pato = new PatoBalancin();
          MrBurns Burns = new MrBurns();
          Planta plata = new Planta(13000, Burns, homero);
          string opcion = "";
          do
          {
           Console.WriteLine(
               "1)ver si la planta en peligro \n"+
               "2)Homero come dona\n"+
               "3)Homero compra dona\n"+
               "4)Lenny toma cerveza\n"+
               "5)Cambiar empleado por Homero\n"+
               "6)Cambiar empleado por Lenny\n"+
               "7)Cambiar empleado por el Pato\n"+
               "8)Despojar a burns de sus riquezas");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                Console.WriteLine(plata.EstaEnPeligro());
                break;
                case "2":
                homero.comer();
                break;
                case "3":
                homero.comprar();
                break;
                case "4":
                lenny.TomarCerveza();
                break;
                case "5":
                plata.CambiarEmpleado(homero);
                break;
                case "6":
                plata.CambiarEmpleado(lenny);
                break;
                case "7":
                plata.CambiarEmpleado(pato);
                break;
                case "8":
                Burns.DespojarDeSusRiquezas();
                break;
            default:
              opcion = "salir";
                break;
            }
          } 
          while (opcion != "salir");
        }
    }
}
