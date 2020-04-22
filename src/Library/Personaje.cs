using System;

namespace Library
{
    public class Personaje
    {
        private string nombre;
        private int vida;

        public Personaje(string nombre, int vida) 
 
        {
            this.Vida = vida;
            this.Nombre = nombre;
        }
        public string Nombre {get; set; }
        public int Vida {get; set; }
    }
}
