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
            this.life = this.life - otherDamage;
            return $"El Mago {this.name} fue atacado, su vida ahora es {this.life}\n";
        }

        public string WizardsCure(int cure)
        {
            this.life = this.life + cure;
            return $"El Mago {this.Name} ha sido curado, su vida ahora es {this.life}";
        }
    }
}
