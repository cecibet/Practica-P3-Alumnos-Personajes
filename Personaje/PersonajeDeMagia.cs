using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int agilidad, int magia, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }

        public PersonajeDeAgilidad(string nombre, int agilidad, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = 60;
            Fuerza = fuerza;
        }

        public int CalcularDanio(int agilidad, int magia, int fuerza)
        {
            return fuerza + agilidad + magia * 4;
        }

        public override int Atacar(string nombre)
        {
            Console.WriteLine($"{nombre} hizo {CalcularDanio()} de daño gracias a su magia.");
        }
    }
}
