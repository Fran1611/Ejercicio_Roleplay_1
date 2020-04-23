

using System;
using System.Collections.Generic;
namespace Library
{
    public class Dwarves
    {

        private string name;
        private int life;
        private List<Item> items;

        public Dwarves(string name, int life, List<Item> items ) 
 
        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
        }
        
        public string Name {get; set; }
        public int Life {get; set; }
        public List<Item> Items {get;set;}
        
        //Este metodo Ataque se le pasa un numero que representa un daño que le ocasiona un personaje al otro.
        //Se obtiene de una lista de objetos de la clase Item y se busca el atributo en este caso Daño.
        //Luego se recalcula una nueva vida luego del ataque considerando que ese personaje puede tener un elemento de proteccion y
        //retorna una actualizacion de su nueva vida.
        
        public string DwarvesAttack(int otherDamage)
        {
            if (otherDamage < 0)
            {
                return $"El Daño no puede ser negativo\n";
            }

            if (this.Life <= 0)
            {
                return $"El Enano {this.Name} fue atacado y ahora está muerto\n";
            }
            else
            {
                return $"El Enano {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }
        }
        
        //En cuanto al metodo de curacion, es muy parecido a el de Ataque pero recibe un número que corresponde a la curación. 
        //Luego se calcula la vida del personaje luego de ser curado y retorna una actualizacion de su nueva vida.


        public string DwarvesCure(int cure)
        {
            if (cure < 0)
            {
                return $"La cura no puede ser negativa\n";
            }

            if (this.Life <= 0)
            {
                return $"El Enano ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {
                    return $"El Enano {this.Name} ya está totalmente curado\n";
                }
                else
                {
                    return $"El Enano {this.Name} ha sido curado, su vida ahora es {this.Life}\n";
                }
            }
        }
    }
}
