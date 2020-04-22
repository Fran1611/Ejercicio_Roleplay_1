using System;
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
        
        public string DwarvesAttack(int otherDamage)
        {
            this.life = this.life - otherDamage;
            return $"El Enano {this.name} fue atacado, su vida ahora es {this.life}\n";
    }
}