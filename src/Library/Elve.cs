using System;
using System.Collections.Generic;
using System.Collections;
namespace Library
{
    public class Elf
    {
        public Elf(string name, int life, List<Item> items)

        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
            InitialLife = life;
        }
        public string Name { get; set;}
        public int Life { get; set;}
        public int InitialLife {get;}
        public List<Item> Items { get; set; }
        
                //El metodo devuelve el nombre del personaje atacado y el valor de su vida luego del ataque.
        
        public ArrayList ElfAttack(int otherDamage)
        {
            ArrayList result = new ArrayList();
            
            this.Life = this.Life - otherDamage;
            result.Add(this.Name);
            result.Add(this.Life);
            return result;
        }
        
        // El metodo DwarvesCure restaura la vida del Elf a su vida inicial, retorna nombre y vida para imprimir.
        public ArrayList ElfCure()
        {
            ArrayList result = new ArrayList();
            this.Life = InitialLife;
            result.Add(this.Life);
            result.Add(this.Name);
            return result;
        }
    }
}
