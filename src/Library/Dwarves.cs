

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
            this.Life = this.Life + this.Items[0].Defence - otherDamage;
            return $"El Enano {this.Name} fue atacado, su vida ahora es {this.Life}\n";
        }
        
        //En cuanto al metodo de curacion, es muy parecido a el de Ataque pero recibe un número que corresponde a la curación. 
        //Luego se calcula la vida del personaje luego de ser curado y retorna una actualizacion de su nueva vida.


        public string DwarvesCure(int cure)
        {
            this.Life = this.Life + cure;
            return $"El Enano {this.Name} ha sido curado, su vida ahora es {this.Life}";
        }
    }
}
