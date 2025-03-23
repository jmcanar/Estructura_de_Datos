class Programa
{
    static void Main()
    {
        var arbol = new ArbolBinario();
        int opcion;
        do
        {
            // Mostrar el menú de opciones
            System.Console.WriteLine("**********************************");
            System.Console.WriteLine("**UNIVERSIDAD ESTATAL AMAZONICA***");
            System.Console.WriteLine("*NOMBRE: JOSE MARCELO CAÑAR JUNCAL");
            System.Console.WriteLine("**********************************");
            Console.WriteLine("=== Árbol Binario de Búsqueda ===");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Mostrar In-Orden");
            Console.WriteLine("5. Mostrar Pre-Orden");
            Console.WriteLine("6. Mostrar Post-Orden");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            // Validar la entrada del usuario
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }
            try
            {
                switch (opcion)
                {
                    case 1: // Insertar
                        Console.Write("Valor a insertar: ");
                        int valorInsertar = Convert.ToInt32(Console.ReadLine());
                        arbol.Insertar(valorInsertar);
                        Console.WriteLine("Valor insertado correctamente.");
                        break;
                    case 2: // Buscar
                        Console.Write("Valor a buscar: ");
                        int valorBuscar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(arbol.Buscar(valorBuscar) 
                            ? "Valor encontrado" 
                            : "Valor no encontrado");
                        break;
                    case 3: // Eliminar
                        Console.Write("Valor a eliminar: ");
                        int valorEliminar = Convert.ToInt32(Console.ReadLine());
                        arbol.Eliminar(valorEliminar);
                        Console.WriteLine("Valor eliminado (si existía)");
                        break;
                    case 4: // In-Orden
                        Console.Write("In-Orden: ");
                        arbol.MostrarInOrden();
                        Console.WriteLine();
                        break;
                    case 5: // Pre-Orden
                        Console.Write("Pre-Orden: ");
                        arbol.MostrarPreOrden();
                        Console.WriteLine();
                        break;
                    case 6: // Post-Orden
                        Console.Write("Post-Orden: ");
                        arbol.MostrarPostOrden();
                        Console.WriteLine();
                        break;
                    case 0: // Salir
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
        } while (opcion != 0);
    }
}