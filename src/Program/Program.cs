
﻿using System;
using Library;
using System.Collections.Generic;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Item espada = new Item("Espada",45,0,null);
            Item baston = new Item("Baston",50,10,null);
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


            Wizard mago = new Wizard("Mago", 60, artMagia);
            Dwarve enano = new Dwarve("Enano",40,itemsEnano);
            Elve elfo = new Elve("Elfo",45,itemsElfo);

            Wizard Gandalf = new Wizard("Gandalf", 100, artMagia);
            
            Wizard hp = new Wizard("Harry Potter", 2, artMagia);
            Wizard lv = new Wizard("Lord Voldemort", 7, artMagia);

            ConsolePrinter print = new ConsolePrinter();

            print.AfterAttack(elfo.ElveAttack(mago.Items[0].Damage));
            print.AfterAttack(mago.WizardAttack(enano.Items[0].Damage));
            print.AfterAttack(enano.DwarveAttack(elfo.Items[0].Damage));
            print.AfterAttack(Gandalf.WizardAttack(elfo.Items[1].Damage));           
            print.AfterAttack(hp.WizardAttack(lv.Items[2].Damage));

            print.AfterCure(elfo.ElveCure());
            
        }
    }
}
