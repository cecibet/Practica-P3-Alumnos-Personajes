namespace Personajes
{
    public class Enemigo : IMoverse
    {
        public int Nivel { get; set; }
        public int Vida { get; set; }

        public void MoverseEjeX()
        {
            Random rnd = new Random();
            int paso = rnd.Next(1, 7);
            Console.WriteLine($"El enemigo ha dado {paso} pasos sobre el eje X");
        }

        public void MoverseEjeY()
        {
            Random rnd = new Random();
            int paso = rnd.Next(1, 7);
            Console.WriteLine($"El enemigo ha dado {paso} pasos sobre el eje Y");

        }
    }

}