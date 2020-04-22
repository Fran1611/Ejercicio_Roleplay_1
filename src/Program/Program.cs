using System;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Library.Personaje hp = new Library.Personaje("Harry Potter", 2);
            Library.Personaje zz = new Library.Personaje("El mago de Oz",7);
            
            Library.Personaje.AddItem("varita",7,3,2);
            Library.Personaje.AddItem("piedra",9,0,0);
            Library.Funciones.Ataque(hp,zz,"piedra");
            Library.Funciones.Cura(zz,hp,"varita");

            Library.ConsolePrinter.TieneVida(hp);
            Library.ConsolePrinter.TieneVida(zz);
        }
     
    }
}
