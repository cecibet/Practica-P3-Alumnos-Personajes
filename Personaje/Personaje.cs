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
       

        public abstract int CalcularDanio();

        public virtual void Atacar()
        {
              Console.WriteLine($"{this.Nombre} hizo {this.CalcularDanio()} de daño.");
        }

         public void MoverseEjeX()
        {
            Random rnd = new Random();
            int paso = rnd.Next(1,7);
            Console.WriteLine($"{this.Nombre} ha dado {paso} pasos sobre el eje Y");
        }
       
         public void MoverseEjeY()
        {
            Random rnd = new Random();
            int paso = rnd.Next(1,7);
            Console.WriteLine($"{this.Nombre} ha dado {paso} pasos sobre el eje Y");

        }
        
    }
}
