using System;
using System.Collections.Generic;

namespace Library
{
    public static class Lucha
    {
        public static void Attack (Personaje a, Personaje b, string description)
        {
            Array myArr = Library.Items.itemsLista;
            var result = Array.Find(myArr, element => element.StartsWith(description, StringComparison.Ordinal));

            a.Vida = a.Vida - result.Item.Daño;
            
        }
      
    
    }
}