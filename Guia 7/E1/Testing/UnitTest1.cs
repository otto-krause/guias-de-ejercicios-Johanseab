using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        PeterParker Parker;
        SpiderGwen Gwen;
        MilesMorales Morales;
        SpidermanNoir Noir;
        Kingpin kingpin;

        [SetUp]
        public void Setup()
        {
            Parker=new PeterParker(400,400);
            Gwen=new SpiderGwen(10,8);
            Noir=new SpidermanNoir(20,20,4);
            Morales=new MilesMorales(5,20);
            kingpin=new Kingpin();
        }

        [Test]
        public void TestElPoderDePeterSon800()
        {
            Assert.AreEqual(800,Parker.poder());
        }
        [Test]
        public void TestElPoderDeNoirEsDe44()
        {
            Assert.AreEqual(44,Noir.poder());
        }
        [Test]
        public void TestElPoderDeGwenEs18()
        {
            Assert.AreEqual(18,Gwen.poder());
        }
        [Test]
        public void TestElGlamourDeGwenSeSobrepasaAlRango()
        {
            SpiderGwen gwen2=new SpiderGwen(11,20);
            Assert.Throws<System.Exception>(()=>gwen2.poder());
        }
        [Test]
        public void TestElPoderDeMilesEs25()
        {
            Assert.AreEqual(25,Morales.poder());
        }
        [Test]
        public void TestKingpingNoFueVencido()
        {
            Assert.AreEqual(false,kingpin.fueVencido());
        }
        [Test]
        public void TestKingpingFueVencido()
        {
            Parker.atacar(kingpin);
            Assert.AreEqual(true,kingpin.fueVencido());
        }
    }
}