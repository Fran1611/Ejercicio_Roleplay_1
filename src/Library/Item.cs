using System;
using System.Collections.Generic;

namespace Library
{    
    public class Item
    {

        private int damage;
        private int defence; 
        //private string name;

        private List<string> spells;

        public Item (string name, int damage, int defence, List<string> spells)
        {
            this.Defence = defence;
            this.Damage = damage;
            this.Name = name;
            this.Spells = spells;
        }

        public string Name {get;set;}
        public int Damage 
        {
            get{return damage;}
        
            set
            {   // El daño no puede ser negativo.
                if(damage < 0)
                {
                    damage = 0;
                } else damage = value;
            }
        }

        public int Defence 
        {
            get{return defence;}
            
            set
            {   // La defensa no puede ser negativa.
                if (defence < 0)
                {
                    defence = 0;
                }else defence = value;
            }
        }

        public List<string> Spells 
        {
            get
            { 
                return spells;
            }

            set
            {   // Los Hechizos solo pueden estar en un Lirbo de Hechizos.
                if (this.Name == "Libro de Hechizos")
                {
                    spells = value;
                }
                else spells = null;
            }        
        }
    }
}
