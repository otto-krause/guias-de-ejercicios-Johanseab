using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        List<int> ingredientes;
        List<Receta> receta;

        Mago HarryPostre;

        [SetUp]
        public void Setup()
        {
            ingredientes=new List<int>();
            ingredientes.Add(400);
            ingredientes.Add(400);
            ingredientes.Add(400);
            receta=new List<Receta>();
            receta.Add(new Receta(ingredientes, 3));
            receta.Add(new Receta(ingredientes, 3));
            receta.Add(new Receta(ingredientes, 1));
            HarryPostre=new Mago(receta);
        }

        [Test]
        public void TestSaberSiTodasLasRecetasSonDeGordo()
        {
            Assert.AreEqual(false,receta.All(receta => receta.esDeGordo()));
        }

        [Test]
        public void TestSaberSiAlgunaRecetaEsRapida()
        {
            Assert.AreEqual(true,receta.Any(receta=>receta.esRapida()));
        }

        [Test]
        public void TestSaberSiHarryEsLento()
        {
            Assert.AreEqual(false,HarryPostre.esUnLento());
        }
        
        [Test]
        public void TestSaberSiHarryNoSeCuida()
        {
            Assert.AreEqual(false,HarryPostre.noSeCuida());
        }
    }
}