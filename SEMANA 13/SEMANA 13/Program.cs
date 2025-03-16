// Clase principal que contiene el punto de entrada del programa
class Programa
{
    static void Main(string[] args)
    {
        BibliotecaRevistas biblioteca = new BibliotecaRevistas();  // Crea una nueva biblioteca

        // Bucle para agregar 10 revistas al catálogo
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el nombre de la revista #{i + 1}: ");
            string nombre = Console.ReadLine();  // Lee el título ingresado por el usuario
            biblioteca.Agregar(nombre);          // Agrega el título al árbol
        }

        int seleccion;  // Variable para almacenar la opción del menú
        do
        {
            // Muestra el menú de opciones
        
           Console.WriteLine("*****************************");
            Console.WriteLine("UNIVERSIDAD ESTATAL AMAZONICA");
            Console.WriteLine("NOMBRE: JOSE MARCELO CAÑAR");
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            System.Console.WriteLine("\n*************************** ");
            seleccion = Convert.ToInt32(Console.ReadLine());  // Lee la selección del usuario

            if (seleccion == 1)  // Opción para buscar una revista
            {
                Console.Write("Ingresa el nombre de la revista a buscar: ");
                string nombreBuscado = Console.ReadLine();    // Lee el título a buscar
                if (biblioteca.ExisteRevista(nombreBuscado))  // Verifica si existe
                {
                    Console.WriteLine("Revista encontrada");
                }
                else
                {
                    Console.WriteLine("Revista no encontrada.");
                }
            }
        } while (seleccion != 0);  // Continúa hasta que el usuario elija salir
    }
}