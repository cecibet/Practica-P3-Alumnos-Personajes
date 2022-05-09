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
            this.Nombre = nombre;
            this.Agilidad = agilidad;
            this.Magia = magia;
            this.Fuerza = fuerza;
        }

        public void PersonajeDeAgilidad(string nombre, int agilidad, int fuerza)
        {
            this.Nombre = nombre;
            this.Agilidad = agilidad;
            this.Magia = 60;
            this.Fuerza = fuerza;
        }

        public override int CalcularDanio()
        {
            return this.Fuerza + this.Agilidad + this.Magia * 4;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{this.Nombre} hizo {this.CalcularDanio()} de daño gracias a su magia.");
        }
    }
}
