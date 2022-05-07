using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personajes
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = 100;
        }

        public int CalcularDanio(int agilidad, int magia, int fuerza)
        {
            return fuerza * 3 + agilidad / 2 + magia;
        }

    }
}