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
        
        //El metodo Ataque, usa un numero que se refiere al daño que un personaje le causa a otro. Este numero se encuentra en una lista
        //de objetos de clase Item, se accede al objeto y se busca el atributo correspondiente al metodo, en este caso Daño.
        //Al calculo de la nueva vida luego de un ataque se le debe sumar la posible defensa que el objeto pueda estar usando. Tambien
        //accediendo al objeto de la lista. Retornara una actualizacion de la nueva vida.

        public string WizardsAttack(int otherDamage)
        {
            if (otherDamage < 0)
            {
                return $"El Daño no puede ser negativo\n";
            }
             this.Life = this.Life - otherDamage;
            if (this.Life <= 0)
            {
                return $"El Mago {this.Name} fue atacado y ahora está muerto\n";
            }
            else
            {
                return $"El Mago {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }

        }
        
        //El metodo curacion funciona muy parecido a Ataque solo que en este caso buscamos que la curacion se sume a la vida del obbjeto.
        //Retorna una actualizacion de la vida del personaje.

        public string WizardsCure(int cure)
        {
            if (cure < 0)
            {
                return $"La cura no puede ser negativa\n";
            }

            if (this.Life <= 0)
            {
                return $"El Mago ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {
                    return $"El Mago {this.Name} ya está totalmente curado\n";
                }
                else
                {
                    return $"El Mago {this.Name} ha sido curado, su vida ahora es {this.Life}\n";
                }
            }


        }
    }
}
