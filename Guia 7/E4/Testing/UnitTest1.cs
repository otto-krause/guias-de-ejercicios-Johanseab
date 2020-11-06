using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        PajarosComunes pajarosComunes;
        Red red;
        Bomb bomb;
        Chuck chuck;
        Terence terence;
        Matilda matilda;
        List<Pajaros> pajaros;
        Huevo huevo;
        IslaPajaros islaPajaros;
        ParedVidrio paredDeVidrio;
        ParedMadera paredDeMadera;
        CerditosObreros obreros;
        List<Obstaculo> obstaculos;

        [SetUp]
        public void Setup()
        {
            pajarosComunes=new PajarosComunes(10);
            red=new Red(10);
            bomb=new Bomb(10);
            chuck=new Chuck(95,10);
            terence=new Terence(10);
            matilda=new Matilda(10);
            pajaros=new List<Pajaros>{pajarosComunes,red,bomb,chuck,terence,matilda};
            huevo=new Huevo(1000);
            paredDeVidrio=new ParedVidrio(20);
            obreros=new CerditosObreros();
            paredDeMadera=new ParedMadera(20);
            obstaculos=new List<Obstaculo>{paredDeVidrio,obreros,paredDeMadera};
            islaPajaros=new IslaPajaros(pajaros,obstaculos);
        }

        [Test]
        public void TestObtenerLaFuerzaDeRedQueDeberiaSer100YHagoEnojarARed()
        {
            red.seEnoja();
            Assert.AreEqual(100, red.fuerza());
        }
        [Test]
        public void TestObtenerALosPajarosFuertesDeLaIslaYObtenerLaFuerzaDeLaIsla()
        {
            int fuerzaTotalDeLaIsla=0;
            List<Pajaros> pajaroFuertes=pajaros.Where(i=>i.fuerza()>50).ToList();
            pajaroFuertes.ForEach(i=>fuerzaTotalDeLaIsla+=i.fuerza());
            Assert.AreEqual(3245,fuerzaTotalDeLaIsla);
        }
        [Test]
        public void TestHacerQueLosPajarosTomenUnaSesionDeManejoDeIraConMatilda()
        {
            Assert.AreEqual(3020, matilda.fuerza());
            islaPajaros.manejarIraConMatilda();
            Assert.AreEqual(3010, matilda.fuerza());
        }
        [Test]
        public void TestSaberSiElPajaroPuedeDerribarElObstaculoYNaceUnPajaro()
        {
            Assert.AreEqual(true,islaPajaros.atacarIslaCerdos());
            huevo.seRompe(islaPajaros);
        }
    }
}