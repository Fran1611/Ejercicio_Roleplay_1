using System;
namespace Library
{
    public class Midget
    {

        private string name;
        private int life;

        public Midget(string name, int life) 
 
        {
            this.Life = life;
            this.Name = name;
        }
        public string Name {get; set; }
        public int Life {get; set; }
    }
}