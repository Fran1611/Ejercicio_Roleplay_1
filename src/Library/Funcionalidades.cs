using System;
using System.Collections.Generic;

namespace Library
{
    public class Funciones
    {
        Lista lista = new Lista();

        public void GetList()
        {
            List<Item> llamada = lista.GetList();
        }
        
        public static void Ataque(Personaje a, Personaje b, string description)
        {
            
            object resultado = llamada.GetList().Find(x => x.Nombre.Contains(description));
            a.Vida = a.Vida - resultado.Daño;
            Console.WriteLine("{0} ataco a {1} y ahora la vida es de {2}",a.Nombre, b.Nombre, a.Vida);
        }

        

    }
}
