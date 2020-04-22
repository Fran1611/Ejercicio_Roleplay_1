using System;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Library.Personaje hp = new Library.Personaje("Harry Potter", 2);
            Library.Personaje zz = new Library.Personaje("El mago de Oz",7);
            Library.ConsolePrinter.TieneVida(hp);
            Library.ConsolePrinter.TieneVida(zz);
            AddItem("piedra",7,0,0);
        }
        
         public static void AddItem(string nombre, int daño, int defensa, int curar)
        {
            itemsLista.Add(new Library.Item (nombre, daño, defensa, curar));
        }
     
    }
}
