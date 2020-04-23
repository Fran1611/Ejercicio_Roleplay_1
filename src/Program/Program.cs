
﻿using System;
using Library;
using System.Collections.Generic;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {


            Item espada = new Item("Espada",20,0,null);
            Item baston = new Item("Baston",25,10,null);
            Item garrote = new Item("Garrote",35,0,null);
            
            Item capa = new Item("Capa de la invisibilidad", 0, 100,null);
            Item varita = new Item("Varita", 100, 45,null);

            Item excalibur = new Item("Excalibur",80,0,null);
            Item gwaihir = new Item("Gwaihir",70,60,null);


            List<Item> artMagia = new List<Item>();
            List<Item> itemsElfo = new List<Item>();
            List<Item> itemsEnano = new List<Item>();
            
            artMagia.Add(baston);
            itemsElfo.Add(garrote);
            itemsEnano.Add(espada);
            
            artMagia.Add(capa);
            artMagia.Add(varita);

            itemsElfo.Add(excalibur);
            artMagia.Add(gwaihir);


            Wizards mago = new Wizards("Mago", 60, artMagia);
            Dwarves enano = new Dwarves("Enano",40,itemsEnano);
            Elves elfo = new Elves("Elfo",45,itemsElfo);

            Wizards Gandalf = new Wizards("Gandalf", 100, artMagia);
            
            Wizards hp = new Wizards("Harry Potter", 2, artMagia);
            Wizards lv = new Wizards("Lord Voldemort", 7, artMagia);

            string firstAttack = elfo.ElvesAttack(mago.Items[0].Damage);   
            string secondAttack = mago.WizardsAttack(enano.Items[0].Damage);
            string thirdAttack = enano.DwarvesAttack(elfo.Items[0].Damage);

            string forthAttack = Gandalf.WizardsAttack(elfo.Items[1].Damage);
            
            string fifthAttack = hp.WizardsAttack(lv.Items[2].Damage);

            // mejorar esto
            Console.WriteLine((firstAttack)+(secondAttack)+(thirdAttack)+(forthAttack)+(fifthAttack));
            Console.WriteLine(mago.WizardsCure(20));
            Console.WriteLine(enano.DwarvesCure(20));
            Console.WriteLine(elfo.ElvesCure(20));
            Console.WriteLine(Gandalf.WizardsCure(20));
            Console.WriteLine(hp.WizardsCure(20));
        }
    }
}
