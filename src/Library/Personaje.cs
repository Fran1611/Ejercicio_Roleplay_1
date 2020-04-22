using System;
using System.Collections.Generic;
namespace Library
{
    public class Personaje
    {
        List<Item> itemsLista = new List<Item>();
        private string nombre;
        private int vida;

        public Personaje(string nombre, int vida) 
 
        {
            this.Vida = vida;
            this.Nombre = nombre;
        }
        public string Nombre {get; set; }
        public int Vida {get; set; }

        public void AddItem(string nombre, int daño, int defensa, int curar)
        {
            itemsLista.Add(new Item(nombre,daño,defensa,curar));
        }

        public void RemoveItem(string nombre, int daño, int defensa, int curar) 
        {
            itemsLista.Remove(new Item() {Nombre = nombre, Daño = daño, Defensa = defensa, Curar = curar});
        }
    }
}
