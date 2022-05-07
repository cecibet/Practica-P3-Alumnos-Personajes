using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract void CalcularDanio();

        public abstract virtual void Atacar(string nombre)
        {
            Console.WriteLine($"{nombre} hizo {CalcularDanio()} de daño.");
        }

         public void MoverseEjeX();
       
         public void MoverseEjeY();
        
    }
}
