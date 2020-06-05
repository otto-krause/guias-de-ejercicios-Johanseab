using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
           Empleado RRHH = new RRHH(7,0);
           Empleado junior = new Programador("junior",0);
           Empleado semiSenior = new Programador("semiSenior",0);
           Empleado senior = new Programador("senior",0);
           Empleado Administrativo= new Administrativo(0);

           string opcion= "";
           int monto;

           while(opcion != "salir")
           {
            Console.WriteLine(
                "[1]Depositar al RRHH\n"+
                "[2]Depositar a los programadores\n"+
                "[3]Depositar al administrativo\n"+
                "[4]Extraer del RRHH\n"+
                "[5]Extraer de un programador\n"+
                "[6]Extraer del Administrativo\n"+
                "[7]Ver caja bancaria del RRHH\n"+
                "[8]Ver caja bancaria de los programadores\n"+
                "[9]Ver caja bancaria del administrativo");
            opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1":
                RRHH.depositan();
                break;
                case "2":
                junior.depositan();
                semiSenior.depositan();
                senior.depositan();
                break;
                case "3":
                Administrativo.depositan();
                break;
                case "4":
                Console.WriteLine("Ingrse el monto deseado a extraer de la cuenta del RRHH");
                monto=Int32.Parse(Console.ReadLine());
                RRHH.extraen(monto);
                break;
                case "5":
                Console.WriteLine("Ingrese el monto deseado a extraer de la cuenta del programador");
                monto=Int32.Parse(Console.ReadLine());
                Console.WriteLine(
                    "[1]Extraer del Junior\n"+
                    "[2]Extraer del semiSenior\n"+
                    "[3]Extraer del senior");
                opcion= Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                    junior.extraen(monto);
                    break;
                    case "2":
                    semiSenior.extraen(monto);
                    break;
                    case "3":
                    senior.extraen(monto);
                    break;    
                }
                break;
                case "6":
                Console.WriteLine("Ingrese el monto deseado a extraer de la cuenta del administrativo");
                monto=Int32.Parse(Console.ReadLine());
                Administrativo.extraen(monto);
                break;
                case "7":
                Console.WriteLine("Monto de la cuenta del RRHH: "+RRHH.CajaBancaria);
                break;
                case "8":
                Console.WriteLine(
                    "Monto de la cuenta del junior: "+junior.CajaBancaria+
                    "\nMonto de la cuenta del semiSenior: "+semiSenior.CajaBancaria+
                    "\nMonto de la cuenta del senior: "+senior.CajaBancaria);
                break;
                case "9":
                Console.WriteLine("Monto de la cuenta del Administrativo: "+Administrativo.CajaBancaria);
                break;
                default:
                opcion="salir";
                break;
            }    
           }
        }
    }
}
