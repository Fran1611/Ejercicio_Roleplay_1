using NUnit.Framework;
using System.Collections.Generic;
namespace Library.Test
{
    public class DwarvesTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]

        // Probamos solo los metodos de la clase mago porque estrucutralmente son los mismos que los demas personajes, y hacen lo mismo.

        public void DwarvesAttack_Damage_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(garrote);
            Dwarves elfo = new Dwarves("Elfo de un ojo", 35, armasElfo);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizards mago = new Wizards("Mago Negro",56,armasMago);
            string attack = mago.WizardsAttack(elfo.Items[0].Damage);   
            string expected = "El Mago Mago Negro fue atacado, su vida ahora es 30\n";

            Assert.AreEqual(expected, attack);
        }

        [Test]
        public void DwarvesCure_Healing_UpdatedLife()
        {
            Item garrote = new Item("Garrote",26,0,null);
            List<Item> armasElfo = new List<Item>();
            armasElfo.Add(garrote);
            Dwarves elfo = new Dwarves("Elfo de un ojo", 35, armasElfo);

            Item paloMagico = new Item("Palo Magico",33,0,null);
            List<Item> armasMago = new List<Item>();
            armasMago.Add(paloMagico);
            Wizards mago = new Wizards("Mago Negro",56,armasMago);
            string heal = mago.WizardsCure(20);   
            string expected = "El Mago Mago Negro ha sido curado, su vida ahora es 76\n";

            Assert.AreEqual(expected, heal);
        }


    }
}