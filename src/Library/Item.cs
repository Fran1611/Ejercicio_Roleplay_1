using System;

namespace Library
{
    public class Item
    {
        private int daño;
        private int defensa; 
        private int curar;
        private string nombre; 

        public int Daño {get;set;}
        public int Defensa {get;set;}
        public int Curar {get;set;}
        public string Nombre {get;set;}

        public Item (string nombre, int daño, int defensa, int curar)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
            this.Curar = curar;
        }






    }
}