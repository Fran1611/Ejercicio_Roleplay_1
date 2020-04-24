using System;
using System.Collections;


namespace Library
{
    public class ConsolePrinter
    {
        public void AfterAttack(ArrayList nameAndLife)
        {
            string name = nameAndLife[0].ToString();
            string life = nameAndLife[1].ToString();
            int newLife = Int32.Parse(life);
            if ( newLife == 0 )
            {
                Console.WriteLine( $"El personaje {name} fue atacado y ahora está muerto\n");
            }
            else
            {
                Console.WriteLine($"El personaje {name} fue atacado, su vida ahora es {newLife}\n");
            }
        }

        public void AfterCure(ArrayList nameAndLife)
        {
            string name = nameAndLife[0].ToString();
            string newLife = nameAndLife[1].ToString();
            Console.WriteLine($"El personaje {name} ha sido curado, si vida es {newLife}");
        }
    }
}