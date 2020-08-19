using NUnit.Framework;
using System.Collections.Generic;
using Ejercicio; 

namespace Testing
{
    public class Tests
    {
        Sables sablesDeLuz;
        Blasters blastersGastado;
        Sables katana;
        List<Arma> armasDeZero;
        Mavericks roberto;
        Mavericks carlos;
        List<Mavericks> mavericks;
        Zero zero;

        [SetUp]
        public void Setup()
        {
            sablesDeLuz=new Sables(0,100,1);
            blastersGastado=new Blasters(0,300,70);
            katana=new Sables(0,55,2);
            armasDeZero=new List<Arma>();
            armasDeZero.Add(sablesDeLuz);
            armasDeZero.Add(blastersGastado);
            armasDeZero.Add(katana);
            roberto=new Mavericks(sablesDeLuz,20);
            carlos=new Mavericks(katana,100);
            mavericks=new List<Mavericks>();
            mavericks.Add(roberto);
            mavericks.Add(carlos);
            zero=new Zero(armasDeZero);
        }

        [Test]
        public void TestElPoderDelSableDeLuz()
        {
            Assert.AreEqual(200, sablesDeLuz.poder());
        }
        [Test]
        public void TestElPoderDelBlasterGastado()
        {
            Assert.AreEqual(230, blastersGastado.poder());
        }
        [Test]
        public void TestElPoderDeLaKatana()
        {
            Assert.AreEqual(220,katana.poder());
        }
        [Test]
        public void TestComprobarSiElArmaMasPolentosaEsElBlasterGastadoYTambienElPoderDeZero()
        {
            Assert.AreEqual(blastersGastado, zero.laMasPolentosa());
            Assert.AreEqual(230,zero.poder());
        }
        [Test]
        public void TestComprobarQueZeroPuedeVencerARoberto()
        {
            Assert.AreEqual(true,zero.loPuedeVencer(roberto));
        }
        [Test]
        public void TestComprobarQueZeroNoPuedeVencerACarlos()
        {
            Assert.AreEqual(false,zero.loPuedeVencer(carlos));
        }
        [Test]
        public void TestComprobarQueZeroNoPuedeVencerALosMavericks()
        {
            Assert.AreEqual(false,zero.losPuedeVencer(mavericks));
        }
    }
}