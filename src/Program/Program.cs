using System;


namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Library.Personaje hp = new Library.Personaje("Harry Potter", 2);
            Library.Personaje zz = new Library.Personaje("El mago de Oz",7);
            
            
            Library.Funciones.Ataque(hp,zz,"piedra");
            Library.Funciones.Cura(zz,hp,"varita");

            Library.ConsolePrinter.TieneVida(hp);
            Library.ConsolePrinter.TieneVida(zz);
        }


    }
}
