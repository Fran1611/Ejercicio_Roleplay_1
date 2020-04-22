using System;

namespace Library
{
    public class BastonMagico
    {
        public int Danio {get;}
        public int Defensa {get;}
        public int Curar {get;}
        public string Nombre {set;}

        public BastonMagico(int danio, int defensa, int curar, string nombre )
        {
            this.Danio=danio;
            this.Defensa=defensa;
            this.Curar= curar;
            this.Nombre=nombre;
        }

    }
}