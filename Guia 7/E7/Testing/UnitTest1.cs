using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Arma LlaveEspada;
        Arma KingdomHeart;
        Arma rayoCongelante;

        Minion Stuwart;
        List<Minion> minions;
        List<string> objetos;
        Ciudad ciudad;
        Villano gru;

        [SetUp]
        public void Setup()
        {
            LlaveEspada= new Arma("Llave Esapada",20);
            KingdomHeart= new Arma("Kingdom Heart",100);
            rayoCongelante= new Arma("Rayo Congelante",10);
            Stuwart=new Minion(rayoCongelante,10,"Amarillo");
            minions=new List<Minion>{Stuwart};
            objetos=new List<string>{"Piramides","Suero Mutante","La Luna"};
            ciudad=new Ciudad(24,objetos,100);
            gru= new Villano(minions,ciudad);
        }

        [Test]
        public void TestCrearUnMinionOtorarUnArmaAUnMinionAlimentarloSaberSiEsPeligrosoYCantidadDeConcentracion()
        {
            gru.nuevoMinion();
            gru.otorgarArma(LlaveEspada);
            gru.otorgarArma(KingdomHeart);
            gru.alimentar(10);
            Assert.AreEqual(true,Stuwart.esPeligroso());
            Assert.AreEqual(120,Stuwart.nivelDeConcentracion());
        }
        [Test]
        public void TestNoPoderRobarSueroMutanteYSaberCualEsElMinionMasUtilStuwart()
        {
            Assert.Throws<System.Exception>(()=>gru.robar("Suero Mutante"));
            Assert.AreEqual(Stuwart,gru.minionMasUtil());
        }
    }
}