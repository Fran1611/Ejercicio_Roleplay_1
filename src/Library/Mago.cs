using System;

namespace Library
{
    public class Mago
    {
        private string name;
        private int life;

        public Mago(string Nombre, BastonMagico baston, int vida)
        {
            this.Vida = vida;
            this.Nombre = Nombre;
        }
        public string Nombre {get;set;}
        public int Vida {get;set;}

        public void Atacar()
        {
            
        }

        public void TieneVida()
        {

        }
    }
}