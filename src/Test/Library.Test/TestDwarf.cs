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
        public void DwarfAttack_Damage_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasEnano = new List<Item>();
            armasEnano.Add(garrote);
            Dwarf enano = new Dwarf("Enano de un ojo", 35, armasEnano);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizard mago = new Wizard("Harry Potter",30,0,null);

            string attack = enano.DwarfAttack(mago.Items[0].Damage);   
            ArrayList expected = new ArrayList();
            expected.Add(enano.Name);
            expected.Add(2);

            Assert.AreEqual(expected, attack);
        }

        [Test]
        public void DwarfCure_Healing_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasEnano = new List<Item>();
            armasEnano.Add(garrote);
            Dwarf enano = new Dwarf("Enano de un ojo", 35, armasEnano);
            
            string heal = enano.DwarfCure();   
            ArrayList expected = new ArrayList();
            expected.Add(enano.Name);
            expected.Add(35);

            Assert.AreEqual(expected, heal);
        }
    }
}