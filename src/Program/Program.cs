
﻿using System;
using Library;
using System.Collections.Generic;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {

            Item espada = new Item("Espada",20,0);
            Item baston = new Item("Baston",25,10);
            Item garrote = new Item("Garrote",35,0);

            Item excalibur = new Item("Excalibur",80,0);
            Item gwaihir = new Item("Gwaihir",70,60);

            List<Item> artMagia = new List<Item>();
            List<Item> itemsElfo = new List<Item>();
            List<Item> itemsEnano = new List<Item>();
            
            artMagia.Add(baston);
            itemsElfo.Add(garrote);
            itemsEnano.Add(espada);

            itemsElfo.Add(excalibur);
            artMagia.Add(gwaihir);


            Wizards mago = new Wizards("Mago", 60, artMagia);
            Dwarves enano = new Dwarves("Enano",40,itemsEnano);
            Elves elfo = new Elves("Elfo",45,itemsElfo);

            Wizards Gandalf = new Wizards("Gandalf", 100, artMagia);

            string firstAttack = elfo.ElvesAttack(mago.Items[0].Damage,elfo.Items[0].Defence);   
            string secondAttack = mago.WizardsAttack(enano.Items[0].Damage,mago.Items[0].Defence);
            string thirdAttack = enano.DwarvesAttack(elfo.Items[0].Damage,enano.Items[0].Defence);

            string forthAttack = Gandalf.WizardsAttack(elfo.Items[1].Damage,mago.Items[1].Defence);

            // mejorar esto
            Console.WriteLine((firstAttack)+(secondAttack)+(thirdAttack)+(forthAttack));
            Console.WriteLine(mago.WizardsCure(20));
            Console.WriteLine(enano.DwarvesCure(20));
            Console.WriteLine(elfo.ElvesCure(20));
            Console.WriteLine(Gandalf.WizardsCure(20));
        }
    }
}
