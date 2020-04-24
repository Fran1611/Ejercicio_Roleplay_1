using System;
using System.Collections.Generic;
namespace Library
{
    public class Dwarf
    {

        public Dwarf(string name, int life, List<Item> items)

        {
            this.Items = items;
            this.Life = ValidateLife(life);
            this.Name = name;
        }

        public int ValidateLife(int life)
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
        
        public string Name {get; set; }
        public int Life {get; set; }
        public List<Item> Items {get;set;}
        
        //Este metodo Ataque se le pasa un numero que representa un daño que le ocasiona un personaje al otro.
        //Se obtiene de una lista de objetos de la clase Item y se busca el atributo en este caso Daño.
        //Luego se recalcula una nueva vida luego del ataque considerando que ese personaje puede tener un elemento de proteccion y
        //retorna una actualizacion de su nueva vida.
        
        public string DwarfAttack(int otherDamage)
        {

           this.Life = this.Life + this.Items[0].Defence - otherDamage;

            if (this.Life <= 0)
            {
                return $"El enano {this.Name} fue atacado y está muerto\n";
            }

            if (otherDamage < 0)
            {
                return $"El daño no puede ser negativo\n";
            }

            else
            {
                return $"El enano {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }


        }
        
        //En cuanto al metodo de curacion, es muy parecido a el de Ataque pero recibe un número que corresponde a la curación. 
        //Luego se calcula la vida del personaje luego de ser curado y retorna una actualizacion de su nueva vida.




        public string DwarfCure(int cure)
        {
            if (cure < 0)
            {   
                cure = 0;
                return $"La cura no puede ser negativa\n";
            }

            if (this.Life <= 0)
            {   
                cure = 0;
                return $"El enano ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {   
                    cure = 100;
                    return $"El enano {this.Name} ya está totalmente curado\n";
                }
                else
                {
                    return $"El enano {this.Name} ha sido curado, su vida ahora es {this.Life}\n";
                }
            }


        }
    }
}
