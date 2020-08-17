using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        private Arma bastonDeMetal;
        private Arma bombasDeHumo;
        private List<Arma> arsenalDeRobin;
        RicardoTapia Robin;
        HulkJunior ChicoBestia;

        Raven raven;

        [SetUp]
        public void Setup()
        {
            bastonDeMetal=new Arma(15,10);
            bombasDeHumo=new Arma(14,89);
            arsenalDeRobin=new List<Arma>();
            arsenalDeRobin.Add(bastonDeMetal);
            arsenalDeRobin.Add(bombasDeHumo);
            Robin = new RicardoTapia(arsenalDeRobin,10);
            ChicoBestia = new HulkJunior(2);
            raven = new Raven(2);
        }

        [Test]
        public void TestCalculoDeFibonacciDelBatonDeMetal()
        {
            Assert.AreEqual(610, bastonDeMetal.Fibonacci());
            Assert.AreEqual(620, bastonDeMetal.Fuerza());
        }  
        [Test] 
        public void TestHacerQueRobinLloreDosVecesPorRobocopYLuegoCalcularSuPoder()
        {
            Robin.llorandoPorRobocop();
            Robin.llorandoPorRobocop();
            Assert.AreEqual(598,Robin.poder());
        }
        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYCalcularPoder()
        {
            ChicoBestia.comerPizza();
            Assert.AreEqual(871,ChicoBestia.poder());
        }
        [Test]
        public void TestChicoBestiaComePizzaYConocerSiElPoderDeRavenEsMayorAlDeLosDemasTitanes()
            {
                ChicoBestia.comerPizza();
                bool masFuerte=false;
                if (raven.poder()>ChicoBestia.poder()&&raven.poder()>Robin.poder())masFuerte=true;
                Assert.AreEqual(false,masFuerte);
            }
        [Test]    
        public void TestNivelDeTriztezaDeChicoBestia()
        {
            ChicoBestia.llorandoPorRobocop();
            Assert.AreEqual(0,ChicoBestia.NivelDeTristeza());
        }
        [Test]
        public void TestRavenComeCuatroPorcionesDePizzaYVerSiEstaTriste()
        {
            raven.comerPizza();
            Assert.AreEqual(true, raven.estarTriste());
        }
        [Test]
            public void TestRivenLloraPorRobocopYVerSiEstaTriste()
            {
                raven.llorandoPorRobocop();
                Assert.AreEqual(false, raven.estarTriste());
            }
    }
    
}