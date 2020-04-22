using System;
namespace Library
{
    public class Wizard
    {

        private string name;
        private int life;

        public Wizard(string name, int life) 
 
        {
            this.Life = life;
            this.Name = name;
        }
        public string Name {get; set; }
        public int Life {get; set; }
    }
}