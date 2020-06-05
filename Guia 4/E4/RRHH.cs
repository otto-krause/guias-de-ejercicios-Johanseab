namespace E4
{
    public class RRHH : Empleado
    {
        int cantidadPersonasReferidas;
        public RRHH(int cantidadPersonasReferidas, int cajaBancaria) : base(cajaBancaria)
        {
            this.cantidadPersonasReferidas=cantidadPersonasReferidas;
        }
        public override void depositan()=> cajaBancaria+=5000+(cantidadPersonasReferidas*5000);
    }
}