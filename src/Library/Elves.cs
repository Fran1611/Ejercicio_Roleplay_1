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
        
        //El metodo ataque recibe un numero que corresponde al daño que un personaje le da a otro. Este numero se obtiene de una lista
        //de objetos de clase Item, se accede a un objeto y se busca su atributo en este caso Daño.
        //Luego se calcula una nueva vida considerando que el personaje puede tener un elemento que lo proteja el cual se suma a su vida
        //y todo esto se resta al daño. Retornara una actualizacion de la vida del personaje.
        
        public string ElvesAttack(int otherDamage)
        {
            if (otherDamage < 0)
            {
                return $"El Daño no puede ser negativo\n";
            }

            this.Life = this.Life - otherDamage;
            if (this.Life <= 0)
            {
                return $"El Elfo {this.Name} fue atacado y ahora está muerto\n";
            }
            else
            {
                return $"El Elfo {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }
        }
        
        //En cuanto al metodo de curacion, este funciona muy parecido a Ataque solo que recibe un número de cuarcion. 
        //para luego sumarlo a su vida. Retornara una actualizacion de la vida del personaje.

        public string ElvesCure(int cure)
        {
             if (cure < 0)
            {
                return $"La cura no puede ser negativa";
            }

            if (this.Life <= 0)
            {
                return $"El Elfo ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {
                    return $"El Elfo {this.Name} ya está totalmente curado";
                }
                else
                {
                    return $"El Elfo {this.Name} ha sido curado, su vida ahora es {this.Life}";
                }
            }
        }
    }
}
