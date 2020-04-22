using System;
using System.Collections.Generic;

namespace Library
{
    public class Funciones
    {
        public static void Ataque(Personaje a, Personaje b, string description)
        {
            object resultado = itemsList.Find(x => x.Nombre.Contains(description));
            a.Vida = a.Vida - resultado.Daño;
            Console.WriteLine("{0] ataca al personaje {1} ahora su vida es de {2}", a.Nombre, b.Nombre, a.Vida);
        }

        public static void Cura(Personaje a, Personaje b, string description)
        {
            object resultado = itemsList.Find(x => x.Nombre.Contains(description));
            a.Vida = a.Vida + resultado.Cura;
            Console.WriteLine("{0} esta curando al personaje {1} ahora su vida es de {2}", a.Nombre, b.Nombre, a.Vida);
        }
    }
}
