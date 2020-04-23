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
        // Test que comprueba que el ataque al Mago se realiza correctamente.
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
    }
}