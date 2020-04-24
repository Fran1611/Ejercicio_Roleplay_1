using System;
using System.Collections.Generic;
namespace Library
{
    public class Elf
    {

        public Elf(string name, int life, List<Item> items)

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

        public string Name { get; set; }
        public int Life { get; set; }

        public List<Item> Items { get; set; }
        
        //El metodo ataque recibe un numero que corresponde al daño que un personaje le da a otro. Este numero se obtiene de una lista
        //de objetos de clase Item, se accede a un objeto y se busca su atributo en este caso Daño.
        //Luego se calcula una nueva vida considerando que el personaje puede tener un elemento que lo proteja el cual se suma a su vida
        //y todo esto se resta al daño. Retornara una actualizacion de la vida del personaje.
        
        public string ElfAttack(int otherDamage)
        {

            this.Life = this.Life + this.Items[0].Defence - otherDamage;

            if (this.Life <= 0)
            {
                return $"El elfo {this.Name} fue atacado y ahora está muerto\n";
            }

             if (otherDamage < 0)
            {
                return $"El daño no puede ser negativo\n";
            }

            else
            {
                return $"El elfo {this.Name} fue atacado, su vida ahora es {this.Life}\n";
            }


        }
        
        //En cuanto al metodo de curacion, este funciona muy parecido a Ataque solo que recibe un número de cuarcion. 
        //para luego sumarlo a su vida. Retornara una actualizacion de la vida del personaje.

        public string ElfCure(int cure)
        {
            if (cure < 0)
            {   
                cure = 0;
                return $"La cura no puede ser negativa\n";
            }

            if (this.Life <= 0)
            {   
                cure = 0;
                return $"El elfo ya está muerto, no se puede curar\n";
            }
            else
            {
                this.Life = this.Life + cure;
                if (this.Life >= 100)
                {   
                    this.Life = 100;
                    return $"El elfo {this.Name} ya está totalmente curado\n";
                }
                else
                {
                    return $"El elfo {this.Name} ha sido curado, su vida ahora es {this.Life}\n";
                }
            }
        }
    }
}
