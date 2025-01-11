//Escribir un programa que almacene las asignaturas de un curso 
//(por ejemplo Matemáticas, Física, Química, Historia y Lengua)
// en una lista y la muestre por pantalla.
public class Ejercicio1
{
    public static void Run()
    {
        Console.WriteLine("Lista de Asignaturas del Curso");
        Console.WriteLine("------------------------------");
        
        // Crear lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };
        
        // Mostrar las asignaturas
        Console.WriteLine("\nLas asignaturas de este curso son:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {asignaturas[i]}");
        }
        
        // Mostrar el total de asignaturas
        Console.WriteLine($"\nTotal de asignaturas: {asignaturas.Count}");
    }
}