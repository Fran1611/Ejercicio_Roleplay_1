
using System;
using System.Collections.Generic;
using System.Collections;
namespace Library
{

// Por patron EXPERT asignamos las responsabilidades del Ataque y Cura del personaje Dwarve, ya que este es experto en conocer su valor de vida.
    public class Dwarf
    {
        private int life;   
        public Dwarf(string name, int life, List<Item> items)

        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
            InitialLife = life;
        }

        public int InitialLife {get;}    
        public string Name {get; set; }
        public int Life
        {
            get{return life;}
            set
            {
                if(value < 0)
                {
                    life =0;
                }
                else life = value;
            }
        }
        public List<Item> Items {get;set;}
        
        //El metodo devuelve el nombre del personaje atacado y el valor de su vida luego del ataque.
        
        public ArrayList  DwarfAttack(int otherDamage)
        {
            ArrayList result = new ArrayList();
            
            this.Life = this.Life - otherDamage;
            result.Add(this.Name);
            result.Add(this.Life);
            return result;
        }
        
        // El metodo DwarvesCure restaura la vida del Elve a su vida inicial, retorna nombre y vida para imprimir.
        public ArrayList DwarfCure()
        {
            ArrayList result = new ArrayList();
            this.Life = InitialLife;
            result.Add(this.Life);
            result.Add(this.Name);
            return result;
        }
    }
}
