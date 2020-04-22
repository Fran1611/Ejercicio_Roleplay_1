using System;

namespace Library
{
    public class BastonMagico
    {
        private int danio;
        private int defensa;
        private int curar;
        private string name;  
        public BastonMagico(string nombre, int danio, int defensa, int curar)
        {
            this.Nombre = nombre;
            this.Danio = danio;
            this.Defensa = defensa;
            this.Curar = curar;
        }

        public int Danio{get;set;}
        public int Defensa{get;set;}
        public int Curar {get;set;}
        public string Nombre {get;set;}

    }
}