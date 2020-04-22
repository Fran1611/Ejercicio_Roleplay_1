using System;

namespace Program
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Library.Wizard hp = new Library.Wizard("Harry Potter", 2);
            Library.Wizard zz = new Library.Wizard("El mago de Oz",7);
           
            Library.ConsolePrinter.TieneVida(hp);
            Library.ConsolePrinter.TieneVida(zz);
        }


    }
}
