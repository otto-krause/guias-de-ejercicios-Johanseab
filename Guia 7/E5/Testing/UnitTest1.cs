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
        Villano laBraba;
        Quirk Love;
        Heroe Endeavor;
        Quirk HellFlame;
        Villano GentleCriminal;
        Quirk Elasticity;

        List<Villano> terrorists;
        Pandilla terroristas;

        [SetUp]
        public void Setup()
        {
            OFA=new Quirk(180,false,"One For All");
            AllMight=new Heroe(OFA);
            HellFlame=new Quirk(300,false,"HellFlame");
            Endeavor=new Heroe(HellFlame);

            Elasticity=new Quirk(60,false,"Elasticity");
            GentleCriminal=new Villano(true,false,false, Elasticity);
            Love=new Quirk(60,false,"Love");
            laBraba=new Villano(false,true,false,Love);
            terrorists = new List<Villano>{laBraba, GentleCriminal};
            terroristas=new Pandilla(terrorists);
        }

        [Test]
        public void TestPoderDeAllMightYEsPeligroso()
        {
            Assert.AreEqual(1980,AllMight.poder());
            Assert.True(AllMight.esPeligroso());
        }
        [Test]
        public void TestElVillanoEsMuyMaloYAlgunaVezFueBueno()
        {
            Assert.False(GentleCriminal.esMuyMalo());
            Assert.True(GentleCriminal.algunaVezFueBueno());
        }
        [Test]
        public void TestEndeavorPeleaContraUnVillanoYLuegoContraUnaPandilla()
        {
            Endeavor.pelearContraVillano(GentleCriminal);
            Assert.AreEqual(1,Endeavor.ContadorDeVictorias);
            Endeavor.pelearContraPandilla(terroristas);
            Assert.AreEqual(2,Endeavor.ContadorDeVictorias);
        }
        [Test]
        public void TestElQuirkDeEndevorEsPeligroso()
        {
            Assert.True(Endeavor.esPeligroso());
        }
    }
}