class Program
{
    static void Main()
    {
        // Inicializar un generador de números aleatorios para asignar ciudadanos vacunados de manera aleatoria
        Random rand = new Random();

        // Crear un conjunto ficticio de 500 ciudadanos utilizando un bucle for, identificados por identidades numéricos del 1 al 500
        // Usamos HashSet para evitar duplicados y garantizar un conjunto único de identidades
        var totalCiudadanos = new HashSet<int>();
        for (int i = 1; i <= 500; i++)
        {
            totalCiudadanos.Add(i); // Agregar cada ID al conjunto de ciudadanos totales
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con Pfizer, seleccionando IDs aleatorios del rango 1-500
        // Usamos un bucle while para asegurarnos de alcanzar exactamente 75 ciudadanos únicos
        var vacunadosPfizer = new HashSet<int>();
        while (vacunadosPfizer.Count < 75)
        {
            int id = rand.Next(1, 501); // Generar un ID aleatorio entre 1 y 500 (inclusive)
            vacunadosPfizer.Add(id); // Agregar el ID al conjunto si no existe ya
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca, seleccionando IDs aleatorios del rango 1-500
        // Similar al enfoque de Pfizer, garantizando 75 ciudadanos únicos
        var vacunadosAstrazeneca = new HashSet<int>();
        while (vacunadosAstrazeneca.Count < 75)
        {
            int id = rand.Next(1, 501); // Generar un ID aleatorio entre 1 y 500 
            vacunadosAstrazeneca.Add(id); // Agregar el ID al conjunto si no existe 
        }

        // Simular 20 ciudadanos que han recibido ambas vacunas (intersección entre Pfizer y AstraZeneca)
        // Tomamos los primeros 20 identidades de los vacunados con Pfizer y los añadimos también a AstraZeneca
        var ambos = new HashSet<int>(vacunadosPfizer.Take(20));
        vacunadosAstrazeneca.UnionWith(ambos); // Asegurar que estos 20 ciudadanos también estén en el conjunto de AstraZeneca

        // Calcular el listado de ciudadanos no vacunados, excluyendo a los vacunados con Pfizer y AstraZeneca del total
        var noVacunados = totalCiudadanos.Except(vacunadosPfizer).Except(vacunadosAstrazeneca).ToList();

        // Calcular el listado de ciudadanos que han recibido ambas vacunas, encontrando la intersección entre Pfizer y AstraZeneca
        var vacunadosDosDoses = vacunadosPfizer.Intersect(vacunadosAstrazeneca).ToList();

        // Calcular el listado de ciudadanos que solo han recibido la vacuna de Pfizer, excluyendo a los que también tienen AstraZeneca
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstrazeneca).ToList();

        // Calcular el listado de ciudadanos que solo han recibido la vacuna de AstraZeneca, excluyendo a los que también tienen Pfizer
        var soloAstrazeneca = vacunadosAstrazeneca.Except(vacunadosPfizer).ToList();

        // Mostrar los resultados con el título de la universidad, sin incluir ejemplos específicos de ciudadanos
        Console.WriteLine("********UNIVERSIDAD ESTATAL AMAZONICA*******");
        Console.WriteLine("**********NOMBRE: JOSE MARCELO CAÑAR********");
        Console.WriteLine($"Total de ciudadanos:");
        Console.WriteLine($"{totalCiudadanos.Count} personas"); // Mostrar el total de ciudadanos
        Console.WriteLine($"Ciudadanos no vacunados:");
        Console.WriteLine($"{noVacunados.Count} personas"); // Mostrar cuántos no están vacunados
        Console.WriteLine($"Ciudadanos vacunados con dos dosis: ");
        Console.WriteLine($"{vacunadosDosDoses.Count} personas"); // Mostrar cuántos tienen ambas vacunas
        Console.WriteLine($"Ciudadanos solo vacunados con Pfizer:");
        Console.WriteLine($"{soloPfizer.Count} personas"); // Mostrar cuántos solo tienen Pfizer
        Console.WriteLine($"Ciudadanos solo vacunados con AstraZeneca:");
        Console.WriteLine($"{soloAstrazeneca.Count} personas"); // Mostrar cuántos solo tienen AstraZeneca
        Console.WriteLine("*******************************************");
    }
}