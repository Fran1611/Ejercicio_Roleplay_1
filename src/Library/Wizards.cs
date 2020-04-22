using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizards

    {   
        private string name;
        private int life;
        private List<Item> items;
        
        public Wizards(string name, int life, List<Item> items)
        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
        }
        public string Name {get;set;}
        public int Life {get;set;}
        public List<Item> Items {get;set;}

        public string WizardsAttack(int otherDamage)
        {
            this.Life = this.Life - otherDamage;
            return $"El Mago {this.Name} fue atacado, su vida ahora es {this.Life}\n";
        }

        public string WizardsCure(int cure)
        {
            this.Life = this.Life + cure;
            return $"El Mago {this.Name} ha sido curado, su vida ahora es {this.Life}";
        }
    }
}
