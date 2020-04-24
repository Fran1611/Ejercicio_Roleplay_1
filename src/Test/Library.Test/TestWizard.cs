using NUnit.Framework;
using System.Collections.Generic;
namespace Library.Test
{
    public class TestDwarf
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void WizardCure_Healing_UpdatedLife()
        {
            Item gar = new Item("Garrote",26,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(gar);
            Wizard mago = new Wizard("Mago de un ojo", 35, armasMago);
            
            string heal = mago.WizardCure();   
            ArrayList expected = new ArrayList();
            expected.Add(mago.Name);
            expected.Add(35);

            Assert.AreEqual(expected, heal);
        }

        [Test]
        public void ElfAttack_Damage_UpdatedLife()
        {
            Item garr = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(garr);
            Elf elfo = new Elf("Elfo de un ojo", 35, armasElfo);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizard mago = new Wizard("Harry Potter",30,0,null);

            string attack = mago.WizardAttack(elfo.Items[0].Damage);   
            ArrayList expected = new ArrayList();
            expected.Add(mago.Name);
            expected.Add(4);

            Assert.AreEqual(expected, attack);
        }
    }
}