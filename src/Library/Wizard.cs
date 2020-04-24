using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard

    {
        private int life;
        public Wizard(string name, int life, List<Item> items)
        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
            InitialLife = life;
        }

        public string Name {get;set;}
        public int Life 
        {
            get{return life;}
            set
            {
                if(life < 0)
                {
                    life = 0;
                }
                else life = value;
            }
        }
        public List<Item> Items {get;set;}
        public int InitialLife {get;}
        
        //El metodo Ataque, usa un numero que se refiere al daño que un personaje le causa a otro. Este numero se encuentra en una lista
        //de objetos de clase Item, se accede al objeto y se busca el atributo correspondiente al metodo, en este caso Daño.
        //Al calculo de la nueva vida luego de un ataque se le debe sumar la posible defensa que el objeto pueda estar usando. Tambien
        //accediendo al objeto de la lista. Retornara una actualizacion de la nueva vida.

        public string WizardAttack(int otherDamage)
        {
            if (this.Life <= 0)
            {
                return $"El Mago {this.Name} fue atacado y ahora está muerto\n";
            }
            else return $"El Mago {this.Name} fue atacado, su vida ahora es {this.Life}\n";
        }
        
        // El metodo WizardsCure restaura la vida del Elve a su vida inicial.
        public string WizardCure()
        {
            this.Life = InitialLife;
            return $"El Mago ha sido curado, su vida es {this.Life}";
        }        
    }
}
