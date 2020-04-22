using System;

namespace Library
{
    public class Funciones
    {
        public static void Ataque(Personaje a, Personaje b, string description)
        {
            object resultado = itemsLista.SingleOrDefault(item => item.Daño == description);
            a.Vida = a.Vida - resultado.Daño;
            Console.WriteLine("{0] ataca al personaje {1} ahora su vida es de {2}", a, b, a.Vida);
        }

        public static void Cura(Personaje a, Personaje b, string description)
        {
            object resultado = itemsLista.SingleOrDefault(item => item.Daño == description);
            a.Vida = a.Vida + resultado.Cura;
            Console.WriteLine("{0} esta curando al personaje {1} ahora su vida es de {2}", a, b, a.Vida);
        }
        
    }
}
