using NUnit.Framework;
using System.Collections.Generic;
namespace Library.Test
{
    public class DwarfTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]

        // Probamos solo los metodos de la clase mago porque estrucutralmente son los mismos que los demas personajes, y hacen lo mismo.

        public void DwarfAttack_Damage_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(garrote);
            Dwarf elfo = new Dwarf("Elfo de un ojo", 35, armasElfo);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizard mago = new Wizard("Mago Negro",56,armasMago);
            string attack = mago.WizardAttack(elfo.Items[0].Damage);   
            string expected = "El Mago Mago Negro fue atacado, su vida ahora es 30\n";

            Assert.AreEqual(expected, attack);
        }

        [Test]
        public void DwarfCure_Healing_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(garrote);
            Dwarf elfo = new Dwarf("Elfo de un ojo", 35, armasElfo);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizard mago = new Wizard("Mago Negro",56,armasMago);
            string heal = mago.WizardCure(20);   
            string expected = "El Mago Mago Negro ha sido curado, su vida ahora es 76\n";

            Assert.AreEqual(expected, heal);
        }


    }
}