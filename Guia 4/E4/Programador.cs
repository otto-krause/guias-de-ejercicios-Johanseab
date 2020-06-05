namespace E4
{
    public class Programador : Empleado
    {
        string tipoDeProgramador;
        public Programador(string tipoDeProgramador,int cajaBancaria) : base(cajaBancaria)
        {
            this.tipoDeProgramador=tipoDeProgramador;
        }
        public override void depositan()
        {
            switch (tipoDeProgramador)
            {
                case "junior":
                cajaBancaria+=30000;
                break;
                case "semiSenior":
                cajaBancaria+=40000;
                break;
                case "senior":
                cajaBancaria+=60000;
                break;
                
            }
        }
    }
}