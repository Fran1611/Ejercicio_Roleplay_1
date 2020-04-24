using System;
using System.Collections;


namespace Library
{

// Por SRP asignamos la responasblididad de imprimir por consola a la clase ConsolePrinter.
    public class ConsolePrinter
    {
        public void AfterAttack(ArrayList nameAndLife)
        {   
            string name = nameAndLife[0].ToString();
            string life = nameAndLife[1].ToString();
            int newLife = Int32.Parse(life);
            
            if (newLife == 0)
            {
                Console.WriteLine($"El perssonaje {name} fue atacado y ahora está muerto\n");
            }
            else
            {
                Console.WriteLine( $"El personaje {name} fue atacado, su vida ahora es {newLife}\n");
            }
        }

        public void AfterCure(ArrayList nameAndLife)
        {   
            string name = nameAndLife[1].ToString();
            string newLife = nameAndLife[0].ToString();
            Console.WriteLine($"El personaje {name} ha sido curado, su vida es {newLife}");
        }
    }
}