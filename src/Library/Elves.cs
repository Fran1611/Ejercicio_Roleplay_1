using System;
using System.Collections.Generic;
namespace Library
{
    public class Elves
    {
        private string name;
        private int life;
        private List<Item> items;

        public Elves(string name, int life, List<Item> items)

        {
            this.Items = items;
            this.Life = life;
            this.Name = name;
        }
        public string Name { get; set; }
        public int Life { get; set; }

        public List<Item> Items { get; set; }

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
