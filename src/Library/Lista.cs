using System;
using System.Collections.Generic;

namespace Library
{
    public class Lista
    {
        private List<Item> itemLista = new List<Item>();
        
        public List<Item> GetList()
        {
            return itemLista;
        }

        public void AddItem(string nombre, int daño, int defensa, int curar)
        {
            itemLista.Add(new Item(nombre,daño,defensa,curar));
        }

        public void RemoveItem(string nombre, int daño, int defensa, int curar) 
        {
            itemLista.Remove(new Item() {Nombre = nombre, Daño = daño, Defensa = defensa, Curar = curar});
        }

    }
}