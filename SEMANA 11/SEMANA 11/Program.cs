class Program
{
    static void Main(string[] args)
    {
        // Diccionario inicial inglés-español con las palabras proporcionadas
        Dictionary<string, string> inglesaespañol = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"company", "empresa"}
        };
        while (true)
        {
            System.Console.WriteLine("================================================");
            System.Console.WriteLine("********UNIVERSIDAD ESTATAL AMAZONICA***********");
            System.Console.WriteLine("**********NOMBRE: JOSE MARCELO CAÑAR************");
            System.Console.WriteLine("================================================");
            Console.WriteLine("********************MENU************************");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(' ');
                    string fraseTraducida = "";

                    // Traducir palabra por palabra
                    foreach (string palabra in palabras)
                    {
                        string palabraLower = palabra.ToLower();
                        if (inglesaespañol.ContainsKey(palabraLower))
                        {
                            fraseTraducida += inglesaespañol[palabraLower] + " ";
                        }
                        else
                        {
                            fraseTraducida += palabra + " ";
                        }
                    }
                    Console.WriteLine($"Su frase traducida es: {fraseTraducida.Trim()}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    break;
                case "2":
                    Console.Write("Ingrese palabra en inglés: ");
                    string palabraeningles = Console.ReadLine().ToLower();
                    Console.Write("Ingrese traducción en español: ");
                    string palabraenespañol = Console.ReadLine().ToLower();
                    if (!inglesaespañol.ContainsKey(palabraeningles))
                    {
                        inglesaespañol.Add(palabraeningles, palabraenespañol);
                        Console.WriteLine("Palabra agregada exitosamente!");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe en el diccionario!");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida!");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    break;
            }
        }
    }
}