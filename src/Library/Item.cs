using System;
using System.Collections;

namespace Library
{
    
    public class Item
    {
        private int daño, defensa, curar;
        private string nombre; 

        public Item (string nombre, int daño, int defensa, int curar)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
            this.Curar = curar;
        }
        public string Nombre {get; set; }
        public int Daño {get;set;}
        public int Defensa {get;set;}
        public int Curar {get;set;}
    }
}
