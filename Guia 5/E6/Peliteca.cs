using System.Collections.Generic;
using System.Linq;
namespace E6
{
    public class Peliteca
    {
        List<Pelicula> peliteca;
        public Peliteca()
        {
            peliteca = new List<Pelicula>();
            Pelicula p1 = new Pelicula("LEGO Batman","Super Heroes","2013","Jon Burton");
            peliteca.Add(p1);
            Pelicula p2 = new Pelicula("Son como niños","Comedia","2010","Dennis Dugan");
            peliteca.Add(p2);
            Pelicula p3 = new Pelicula("Castillo Vagabundo","Fantasia","2003","Hayao Miyazaki");
            peliteca.Add(p3);
            Pelicula p4 = new Pelicula("Ponyo","Animacion","2009","Hayao Miyazaki");
            peliteca.Add(p4);
            Pelicula p5 = new Pelicula("My Hero Academia Two Heroes","Super Heroes","2018","Kenji Nagasaki");
            peliteca.Add(p5);
        }
        public List<string> Buscador(string busqueda,string opcion)
        {
            List<string> descripcion = new List<string>();
            switch (opcion)
            {
                case "1":
                peliteca.Where(i=>i.Genero==busqueda).ToList().ForEach(i=>descripcion.Add(i.getDescripcion()));
                break;
                case "2":
                peliteca.Where(i=>i.Nombre==busqueda).ToList().ForEach(i=>descripcion.Add(i.getDescripcion()));
                break;
                case "3":
                peliteca.Where(i=>i.Año==busqueda).ToList().ForEach(i=>descripcion.Add(i.getDescripcion()));
                break;
                case "4":
                peliteca.Where(i=>i.Director==busqueda).ToList().ForEach(i=>descripcion.Add(i.getDescripcion()));
                break;
            }
            return descripcion;
        }
        public int CantidadDePeliculas()
        {
            return peliteca.Count;
        }
        public int CantidadDePeliculasPorGenero(string genero)
        {
            return peliteca.Count(i=>i.Genero==genero);
        }
    }
}