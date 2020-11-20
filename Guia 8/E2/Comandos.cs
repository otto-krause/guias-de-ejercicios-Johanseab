using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace E2
{
    public class Comandos
    {
        string json;
        Root root;

        public void cargarJSON()
        {
            using(StreamReader r=new StreamReader("General.json"))
            {
                json=r.ReadToEnd();
            }
            root = JsonSerializer.Deserialize<Root>(json);
        }

        public string Buscar(double longitud, double latitud)
        {
            double menor=root.locales[0].coordenadas.latitud+root.locales[0].coordenadas.longitud;
            string nombre=root.locales[0].nombre;
            foreach (var local in root.locales)
            {
                if(longitud+latitud-menor>local.coordenadas.latitud+local.coordenadas.longitud-longitud+latitud)
                {
                    menor=local.coordenadas.latitud+local.coordenadas.longitud-longitud+latitud;
                    nombre=local.nombre;
                }
            }
            return nombre;
        }
        public bool BuscarTrabajo(double longitud,double latitud)
        {
            bool res=false;
            List<Local> localesCerca=root.locales.OrderBy(local=>local.coordenadas.latitud+local.coordenadas.longitud-longitud+latitud).ToList();

            for(int i=0; i<5 ; i++)
            {
                if(localesCerca[i].empleados.Any(e=>e.asignadoA==""))
                res=true;
            }
            return res;
        }
    }
}