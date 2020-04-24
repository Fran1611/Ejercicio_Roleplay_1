using System;
using System.Collections.Generic;
namespace Library
{
    public class Elve
    {
        public Elve(string name, int life, List<Item> items)

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
        
        //El metodo ataque recibe un numero que corresponde al daño que un personaje le da a otro. Este numero se obtiene de una lista
        //de objetos de clase Item, se accede a un objeto y se busca su atributo en este caso Daño.
        //Luego se calcula una nueva vida considerando que el personaje puede tener un elemento que lo proteja el cual se suma a su vida
        //y todo esto se resta al daño. Retornara una actualizacion de la vida del personaje.
        
        public string ElveAttack(int otherDamage)
        {
            this.Life = (this.Life - otherDamage);
            if (this.Life <= 0)
            {
                return $"El Elfo {this.Name} fue atacado y ahora está muerto\n";
            }
            else
            {
                return $"El Elfo {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }
        }
        
        // El metodo ElvesCure restaura la vida del Elve a su vida inicial.
        public string ElveCure()
        {
            this.Life = InitialLife;
            return $"El Elfo ha sido curado, su vida es {this.Life}";
        }
    }
}
