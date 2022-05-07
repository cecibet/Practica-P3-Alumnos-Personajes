using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, int agilidad, int magia, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }
    }

    public int CalcularDanio(int agilidad, int magia, int fuerza)
    {
        return fuerza / 2 * agilidad * magia / 2;
    }
}
