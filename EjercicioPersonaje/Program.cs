using Personajes;


PersonajeDeFuerza personajeDeFuerza1 = new("Jax", 45, 15);
PersonajeDeAgilidad personajeDeAgilidad1 = new("Jade", 75, 50, 15);
PersonajeDeMagia personajeDeMagia1 = new("Raiden", 30, 80, 35);

List<Personaje> personajes = new List<Personaje>();
personajes.Add(personajeDeFuerza1);
personajes.Add(personajeDeAgilidad1);    
personajes.Add(personajeDeMagia1);

Turno.Atacarse(personajes);

