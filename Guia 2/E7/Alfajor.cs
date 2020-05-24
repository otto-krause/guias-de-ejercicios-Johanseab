namespace E7
{
    public class Alfajor
    {
        string nombre;
        int precio;
        public int Precio{ get => precio; }
        string NombreDeLaEmpresa;

        public Alfajor(string nombre, int precio, string NombreDeLaEmpresa)
        {
            this.nombre=nombre;
            this.precio=precio;
            this.NombreDeLaEmpresa=NombreDeLaEmpresa;
        }
        public void Aumentos(int opcion)
        {
            switch(opcion)
            {
                case 1:
                precio+=80;
                break;
                case 2:
                precio*=2;
                break;
                case 3:
                if (NombreDeLaEmpresa != "Waymayen")
                {
                    precio+=1000;
                }
                break;
            }
        }
    }
}