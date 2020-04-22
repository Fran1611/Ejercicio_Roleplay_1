using System;
using System.Collections.Generic;
namespace Library
{
    public class Elves
    {

        private string name;
        private int life;
        private List<Item> items;
        
        public Elves(string name, int life, List<Item> items ) 
 
        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
        }
        public string Name {get; set; }
        public int Life {get; set; }

        public List<Item> Items {get;set;}
        
        public string ElvesAttack(int otherDamage)
        {
            this.life = this.life - otherDamage;
            return $"El Elfo {this.name} fue atacado, su vida ahora es {this.life}\n";
        }
        public string ElvesCure(int cure)
        {
            this.life = this.life + cure;
            return $"El Elfo {this.Name} ha sido curado, su vida ahora es {this.life}";
        }
    }
}
