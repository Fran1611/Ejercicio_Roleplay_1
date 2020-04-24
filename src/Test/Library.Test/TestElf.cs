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
        public void ElfAttack_Damage_UpdatedLife()
        {
            Item g = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(g);
            Elf elfo = new Elf("Elfo de un ojo", 35, armasElfo);

            Item p = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(p);
            Wizard mago = new Wizard("Harry Potter",30,0,null);

            string attack = elfo.ElfAttack(mago.Items[0].Damage);   
            ArrayList expected = new ArrayList();
            expected.Add(elfo.Name);
            expected.Add(2);

            Assert.AreEqual(expected, attack);
            }
        [Test]
        public void ElfCure_Healing_UpdatedLife()
        {
            Item ga = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(ga);
            Elf elfo = new Elf("Enano de un ojo", 35, armasElfo);
                        
            string heal = elfo.ElfCure();   
            ArrayList expected = new ArrayList();
            expected.Add(elfo.Name);
            expected.Add(35);

            Assert.AreEqual(expected, heal);
        }
    }
}