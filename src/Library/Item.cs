using System;
using System.Collections;

namespace Library
{
    
    public class Item
    {
        ArrayList itemsLista = new ArrayList();
        private int daño, defensa, curar;
        private string nombre; 

        public static void Main(string[] args)
        {
            AddItem("varita",7,3,2);
            AddItem("piedra",9,0,0);
        }
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

        public static void AddItem(string nombre, int daño, int defensa, int curar)
        {
            itemsLista.Add(new Library.Item (nombre, daño, defensa, curar));
        }
    

    }
}
