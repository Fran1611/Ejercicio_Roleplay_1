using System;

namespace Library
{
    public class Personaje
    {
        ArrayList itemsLista = new ArrayList();
        private string nombre;
        private int vida;

        public Personaje(string nombre, int vida) 
 
        {
            this.Vida = vida;
            this.Nombre = nombre;
        }
        public string Nombre {get; set; }
        public int Vida {get; set; }
        
        public static void AddItem(string nombre, int daño, int defensa, int curar)
        {
            itemsLista.Add(new Library.Item (nombre, daño, defensa, curar));
        }
    }
}
