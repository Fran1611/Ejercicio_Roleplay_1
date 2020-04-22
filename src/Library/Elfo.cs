using System;
namespace Library
{
    public class Elf
    {

        private string name;
        private int life;

        public Elf(string name, int life) 
 
        {
            this.Life = life;
            this.Name = name;
        }
        public string Name {get; set; }
        public int Life {get; set; }
    }
}