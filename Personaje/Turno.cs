namespace Personajes
{
    internal static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            throw new NotImplementedException();
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}