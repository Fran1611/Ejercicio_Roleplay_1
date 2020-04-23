using System;
using System.Collections.Generic;

namespace Library
{
    
    public class Item
    {

        private int damage;
        private int defence; 
        private string name;
        private List<string> spells;

        public Item (string name, int damage, int defence, List<string> spells)
        {
            this.Defence = defence;
            this.Damage = damage;
            this.Name = name;
            this.Spells = spells;
        }
        public int Damage {get;set;}
        public int Defence {get;set;}
        public string Name {get;set;}
        public List<string> Spells 
        {
            get
            { 
                return spells;
            }

            set
            {
                if (this.Name == "Libro de Hechizos")
                {
                    spells = value;
                }
                else spells = null;
            }        
        }
    }
}
