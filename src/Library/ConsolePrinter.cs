using System;

namespace Library
{
    public class ConsolePrinter
    {
        public static string TieneVida(Personaje personaje)
        {
            if(personaje.Vida >0)
            {
                return $"el personaje {personaje.Nombre} tiene {personaje.Vida} de vida";
            }
            else return $"el personaje {personaje.Nombre} murió";
        }
    }
}