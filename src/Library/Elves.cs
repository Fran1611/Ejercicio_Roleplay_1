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
            this.Life = this.Life + this.Item[0].Defense - otherDamage;
            return $"El Elfo {this.Name} fue atacado, su vida ahora es {this.Life}\n";
        }
        
        //En cuanto al metodo de curacion, este funciona muy parecido a Ataque solo que buscamos unn atributo de curacion en la lista
        //de objetos, para luego sumarlo a su vida. Retornara una actualizacion de la vida del personaje.

        public string ElvesCure(int cure)
        {
            this.Life = this.Life + cure;
            return $"El Elfo {this.Name} ha sido curado, su vida ahora es {this.Life}";
        }
    }
}
