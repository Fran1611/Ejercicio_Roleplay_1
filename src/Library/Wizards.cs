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
            this.Life = ValidarVida(life);
            this.Name = name;
        }

        public int ValidarVida(int life)
        {
            if (life < 1)
            {   
                Console.WriteLine("La minima vida es 1\n");
                return 1;
            }else
            {
                if (life > 100)
                {   
                    Console.WriteLine("La maxima vida es 100\n");
                    return 100;
                }
            }

            return life;
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

            this.Life = this.Life + this.Items[0].Defence - otherDamage;

            if (this.Life <= 0)
            {
                return $"El mago {this.Name} está muerto\n";
            }

            return $"El mago {this.Name} fue atacado, su vida ahora es {this.Life}\n";

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
                cure = 0;
                return $"La cura no puede ser negativa\n";
            }

            if (this.Life <= 0)
            {   
                cure = 0;
                return $"El mago {this.Name} ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {   
                    this.Life = 100;
                    return $"El mago {this.Name} ya está totalmente curado\n";
                }
                else
                {
                    return $"El mago {this.Name} ha sido curado, su vida ahora es {this.Life}\n";
                }
            }


        }
    }
}
