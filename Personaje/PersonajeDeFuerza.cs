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
            this.Nombre = nombre;
            this.Agilidad = agilidad;
            this.Magia = magia;
            this.Fuerza = 100;
        }

        public override int CalcularDanio()
        {
            return this.Fuerza * 3 + this.Agilidad / 2 + this.Magia / 2;
        }

    }
}