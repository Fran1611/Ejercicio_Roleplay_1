using System;
using System.Collections;
namespace Library
{
    public class Personaje
    {
        private string nombre;
        private int vida;
        private ArrayList items;

        public Personaje(string nombre, int vida, ArrayList items)
        {
            this.Vida = vida;
            this.Nombre = nombre;
        }
        public string Nombre {get;set;}
        public int Vida {get;set;}

        public ArrayList Items {get;set;}

        public void Atacar(Personaje PersonajeAtacado)
        {
            // hay que definirlo cuando tengamos la clase items
        }

        public string TieneVida(Personaje personaje)
        {
            if(this.vida >0)
            {
                return $"el personaje {this.Nombre} tiene {this.Vida} de vida";
            }
            else return $"el personaje {this.Nombre} murió";
        }
    }
}