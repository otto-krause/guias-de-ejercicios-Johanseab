using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Heroe AllMight;
        Quirk OFA;
        Heroe ArturoMirodilla;
        Quirk PiroQuinesis;
        Villano Gentlecriminal;
        Quirk Elasticity;
        Villano laBraba;
        Quirk Love;
        Heroe Endeavor;
        Quirk HellFlame;
        List<Villano> terrorists;
        Pandilla terroristas;

        [SetUp]
        public void Setup()
        {
            OFA= new Quirk(180,false,"One for All");
            AllMight= new Heroe(OFA);
            HellFlame = new Quirk(300,false,"HellFlame");
            Endeavor=new Heroe(HellFlame);
            PiroQuinesis=new Quirk(300,false,"PiroQuinesis");
            ArturoMirodilla=new Heroe(OFA);

            Elasticity=new Quirk(60,false,"Elasticity");
            Gentlecriminal=new Villano(true,false,false,Elasticity);
            Love=new Quirk(60,false,"Love");
            laBraba=new Villano(false,true,false,Love);
            terrorists=new List<Villano>{laBraba,Gentlecriminal};
            terroristas=new Pandilla(terrorists);
        }

        [Test]
        public void TestPoderDeAllMightYEsPeligroso()
        {
            Assert.AreEqual(1980, AllMight.poder());
            Assert.True(AllMight.esPeligroso());
        }
        [Test]
        public void TestElVillanoEsMuyMaloYAlgunaVezFueBueno()
        {
            Assert.False(Gentlecriminal.esMuyMalo());
            Assert.True(Gentlecriminal.algunaVezFueBueno());
        }
        [Test]
        public void TestEndeavorPeleaContraUnVillanoYLuegoContraUnaPandilla()
        {
            Endeavor.pelearContraVillano(Gentlecriminal);
            Assert.AreEqual(1,Endeavor.ContadorDeVictorias);
            Endeavor.pelearContraPandilla(terroristas);
            Assert.AreEqual(2,Endeavor.ContadorDeVictorias);
        }
        [Test]
        public void TestElQuirkDeEndeavorEsPeligroso()
        {
            Assert.True(Endeavor.esPeligroso());
        }
        [Test]
        public void Test()
        {
            OneForAll ofa=new OneForAll(AllMight);
            ofa.cambiarPortador(ArturoMirodilla);
            Assert.AreEqual(2,ArturoMirodilla.Quirks.Count());

            Heroe portadorAleatorio=new Heroe(PiroQuinesis);
            ofa.cambiarPortador(portadorAleatorio);
            Assert.AreEqual(1,ArturoMirodilla.Quirks.Count());
        }
    }
}