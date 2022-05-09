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
            this.Nombre = nombre;
            this.Agilidad = agilidad;
            this.Magia = magia;
            this.Fuerza = fuerza;
        }

        public override int CalcularDanio()
        {
            return this.Fuerza / 2 * this.Agilidad * this.Magia / 2;
        }
    }

}
