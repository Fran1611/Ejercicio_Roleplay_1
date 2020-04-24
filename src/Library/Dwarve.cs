

using System;
using System.Collections.Generic;
namespace Library
{
    public class Dwarve
    {
        private int life;   
        public Dwarve(string name, int life, List<Item> items)

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
                if(life < 0)
                {
                    life =0;
                }
                else life = value;
            }
        }
        public List<Item> Items {get;set;}
        
        //Este metodo Ataque se le pasa un numero que representa un daño que le ocasiona un personaje al otro.
        //Se obtiene de una lista de objetos de la clase Item y se busca el atributo en este caso Daño.
        //Luego se recalcula una nueva vida luego del ataque considerando que ese personaje puede tener un elemento de proteccion y
        //retorna una actualizacion de su nueva vida.
        
        public string DwarveAttack(int otherDamage)
        {
            if (this.Life <= 0)
            {
                return $"El Enano {this.Name} fue atacado y ahora está muerto\n";
            }
            else return $"El Enano {this.Name} fue atacado, su vida ahora es {this.Life}\n";
        }
        
        // El metodo DwarvesCure restaura la vida del Elve a su vida inicial.
        public string DwarveCure()
        {
            this.Life = InitialLife;
            return $"El Enano ha sido curado, su vida es {this.Life}";
        }
    }
}
